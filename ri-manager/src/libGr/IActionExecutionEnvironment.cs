/*
 * GrGen: graph rewrite generator tool -- release GrGen.NET 3.0
 * Copyright (C) 2003-2011 Universitaet Karlsruhe, Institut fuer Programmstrukturen und Datenorganisation, LS Goos
 * licensed under LGPL v3 (see LICENSE.txt included in the packaging of this file)
 * www.grgen.net
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace de.unika.ipd.grGen.libGr
{
    #region ActionExecutionDelegates

    /// <summary>
    /// Represents a method called after all requested matches of an action have been matched.
    /// </summary>
    /// <param name="matches">The matches found.</param>
    /// <param name="special">Specifies whether the "special" flag has been used.</param>
    public delegate void AfterMatchHandler(IMatches matches, bool special);

    /// <summary>
    /// Represents a method called before the rewrite step of an action, when at least one match has been found.
    /// </summary>
    /// <param name="matches">The matches found.</param>
    /// <param name="special">Specifies whether the "special" flag has been used.</param>
    public delegate void BeforeFinishHandler(IMatches matches, bool special);

    /// <summary>
    /// Represents a method called during rewriting a set of matches before the next match is rewritten.
    /// It is not fired before rewriting the first match.
    /// </summary>
    public delegate void RewriteNextMatchHandler();

    /// <summary>
    /// Represents a method called after the rewrite step of a rule.
    /// </summary>
    /// <param name="matches">The matches found.
    /// This may contain invalid entries, because parts of the matches may have been deleted.</param>
    /// <param name="special">Specifies whether the "special" flag has been used.</param>
    public delegate void AfterFinishHandler(IMatches matches, bool special);

    #endregion ActionExecutionDelegates


    /// <summary>
    /// An environment for the execution of actions (without embedded sequences).
    /// Holds a refernce to the current graph.
    /// </summary>
    public interface IActionExecutionEnvironment
    {
        /// <summary>
        /// If PerformanceInfo is non-null, this object is used to accumulate information about time, found matches and applied rewrites.
        /// By default it should be null.
        /// The user is responsible for resetting the PerformanceInfo object.
        /// </summary>
        PerformanceInfo PerformanceInfo { get; set; }

        /// <summary>
        /// The maximum number of matches to be returned for a RuleAll sequence element.
        /// If it is zero or less, the number of matches is unlimited.
        /// </summary>
        int MaxMatches { get; set; }

        /// <summary>
        /// Returns the graph currently focused in processing / sequence execution.
        /// </summary>
        IGraph Graph { get; set; }

        /// <summary>
        /// The actions employed by this graph processing environment
        /// </summary>
        BaseActions Actions { get; set; }

        /// <summary>
        /// Does graph processing environment dependent stuff.
        /// </summary>
        /// <param name="args">Any kind of paramteres for the stuff to do</param>
        void Custom(params object[] args);


        #region Graph rewriting

        /// <summary>
        /// Retrieves the newest version of an IAction object currently available for this graph.
        /// This may be the given object.
        /// </summary>
        /// <param name="action">The IAction object.</param>
        /// <returns>The newest version of the given action.</returns>
        IAction GetNewestActionVersion(IAction action);

        /// <summary>
        /// Sets the newest action version for a static action.
        /// </summary>
        /// <param name="staticAction">The original action generated by GrGen.exe.</param>
        /// <param name="newAction">A new action instance.</param>
        void SetNewestActionVersion(IAction staticAction, IAction newAction);

        /// <summary>
        /// Executes the modifications of the according rule to the given match/matches.
        /// Fires OnRewritingNextMatch events before each rewrite except for the first one.
        /// </summary>
        /// <param name="matches">The matches object returned by a previous matcher call.</param>
        /// <param name="which">The index of the match in the matches object to be applied,
        /// or -1, if all matches are to be applied.</param>
        /// <returns>A possibly empty array of objects returned by the last applied rewrite.</returns>
        object[] Replace(IMatches matches, int which);

        #endregion Graph rewriting     
        

        #region Events

        /// <summary>
        /// Fired after all requested matches of a rule have been matched.
        /// </summary>
        event AfterMatchHandler OnMatched;

        /// <summary>
        /// Fired before the rewrite step of a rule, when at least one match has been found.
        /// </summary>
        event BeforeFinishHandler OnFinishing;

        /// <summary>
        /// Fired before the next match is rewritten. It is not fired before rewriting the first match.
        /// </summary>
        event RewriteNextMatchHandler OnRewritingNextMatch;

        /// <summary>
        /// Fired after the rewrite step of a rule.
        /// Note, that the given matches object may contain invalid entries,
        /// as parts of the match may have been deleted!
        /// </summary>
        event AfterFinishHandler OnFinished;


        /// <summary>
        /// Fires an OnMatched event.
        /// </summary>
        /// <param name="matches">The IMatches object returned by the matcher.</param>
        /// <param name="special">Whether this is a 'special' match (user defined).</param>
        void Matched(IMatches matches, bool special);

        /// <summary>
        /// Fires an OnFinishing event.
        /// </summary>
        /// <param name="matches">The IMatches object returned by the matcher.</param>
        /// <param name="special">Whether this is a 'special' match (user defined).</param>
        void Finishing(IMatches matches, bool special);

        /// <summary>
        /// Fires an OnRewritingNextMatch event.
        /// </summary>
        void RewritingNextMatch();

        /// <summary>
        /// Fires an OnFinished event.
        /// </summary>
        /// <param name="matches">The IMatches object returned by the matcher. The elements may be invalid.</param>
        /// <param name="special">Whether this is a 'special' match (user defined).</param>
        void Finished(IMatches matches, bool special);

        #endregion Events
    }
}
