// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "ReplaceManager.grg" on Wed Mar 14 21:13:06 CET 2012

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_ReplaceManager;

namespace de.unika.ipd.grGen.Action_ReplaceManager
{
	public class Rule_checkStructurePre : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_checkStructurePre instance = null;
		public static Rule_checkStructurePre Instance { get { if (instance==null) { instance = new Rule_checkStructurePre(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] checkStructurePre_node_x1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePre_node_x4_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePre_node_x2_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePre_node_x3_AllowedTypes = null;
		public static bool[] checkStructurePre_node_x1_IsAllowedType = null;
		public static bool[] checkStructurePre_node_x4_IsAllowedType = null;
		public static bool[] checkStructurePre_node_x2_IsAllowedType = null;
		public static bool[] checkStructurePre_node_x3_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePre_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePre_edge__edge1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePre_edge__edge2_AllowedTypes = null;
		public static bool[] checkStructurePre_edge__edge0_IsAllowedType = null;
		public static bool[] checkStructurePre_edge__edge1_IsAllowedType = null;
		public static bool[] checkStructurePre_edge__edge2_IsAllowedType = null;
		public enum checkStructurePre_NodeNums { @x1, @x4, @x2, @x3, };
		public enum checkStructurePre_EdgeNums { @_edge0, @_edge1, @_edge2, };
		public enum checkStructurePre_VariableNums { };
		public enum checkStructurePre_SubNums { };
		public enum checkStructurePre_AltNums { };
		public enum checkStructurePre_IterNums { };



		public GRGEN_LGSP.PatternGraph pat_checkStructurePre;


		private Rule_checkStructurePre()
		{
			name = "checkStructurePre";

			inputs = new GRGEN_LIBGR.GrGenType[] { };
			inputNames = new string[] { };
			defs = new GRGEN_LIBGR.GrGenType[] { };
			defNames = new string[] { };
			outputs = new GRGEN_LIBGR.GrGenType[] { };

		}
		private void initialize()
		{
			bool[,] checkStructurePre_isNodeHomomorphicGlobal = new bool[4, 4] {
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
			};
			bool[,] checkStructurePre_isEdgeHomomorphicGlobal = new bool[3, 3] {
				{ false, false, false, },
				{ false, false, false, },
				{ false, false, false, },
			};
			bool[] checkStructurePre_isNodeTotallyHomomorphic = new bool[4] { false, false, false, false,  };
			bool[] checkStructurePre_isEdgeTotallyHomomorphic = new bool[3] { false, false, false,  };
			GRGEN_LGSP.PatternNode checkStructurePre_node_x1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePre_node_x1", "x1", checkStructurePre_node_x1_AllowedTypes, checkStructurePre_node_x1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePre_node_x4 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePre_node_x4", "x4", checkStructurePre_node_x4_AllowedTypes, checkStructurePre_node_x4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePre_node_x2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePre_node_x2", "x2", checkStructurePre_node_x2_AllowedTypes, checkStructurePre_node_x2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePre_node_x3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePre_node_x3", "x3", checkStructurePre_node_x3_AllowedTypes, checkStructurePre_node_x3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePre_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePre_edge__edge0", "_edge0", checkStructurePre_edge__edge0_AllowedTypes, checkStructurePre_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePre_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePre_edge__edge1", "_edge1", checkStructurePre_edge__edge1_AllowedTypes, checkStructurePre_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePre_edge__edge2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePre_edge__edge2", "_edge2", checkStructurePre_edge__edge2_AllowedTypes, checkStructurePre_edge__edge2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternCondition checkStructurePre_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePre_node_x1", "id"), new GRGEN_EXPR.Constant("1")),
				new string[] { "checkStructurePre_node_x1" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePre_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePre_node_x2", "id"), new GRGEN_EXPR.Constant("2")),
				new string[] { "checkStructurePre_node_x2" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePre_cond_2 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePre_node_x3", "id"), new GRGEN_EXPR.Constant("3")),
				new string[] { "checkStructurePre_node_x3" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePre_cond_3 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePre_node_x4", "id"), new GRGEN_EXPR.Constant("4")),
				new string[] { "checkStructurePre_node_x4" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			pat_checkStructurePre = new GRGEN_LGSP.PatternGraph(
				"checkStructurePre",
				"",
				false, false,
				new GRGEN_LGSP.PatternNode[] { checkStructurePre_node_x1, checkStructurePre_node_x4, checkStructurePre_node_x2, checkStructurePre_node_x3 }, 
				new GRGEN_LGSP.PatternEdge[] { checkStructurePre_edge__edge0, checkStructurePre_edge__edge1, checkStructurePre_edge__edge2 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { checkStructurePre_cond_0, checkStructurePre_cond_1, checkStructurePre_cond_2, checkStructurePre_cond_3,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[4, 4] {
					{ true, false, false, false, },
					{ false, true, false, false, },
					{ false, false, true, false, },
					{ false, false, false, true, },
				},
				new bool[3, 3] {
					{ true, false, false, },
					{ false, true, false, },
					{ false, false, true, },
				},
				checkStructurePre_isNodeHomomorphicGlobal,
				checkStructurePre_isEdgeHomomorphicGlobal,
				checkStructurePre_isNodeTotallyHomomorphic,
				checkStructurePre_isEdgeTotallyHomomorphic
			);
			pat_checkStructurePre.edgeToSourceNode.Add(checkStructurePre_edge__edge0, checkStructurePre_node_x1);
			pat_checkStructurePre.edgeToTargetNode.Add(checkStructurePre_edge__edge0, checkStructurePre_node_x4);
			pat_checkStructurePre.edgeToSourceNode.Add(checkStructurePre_edge__edge1, checkStructurePre_node_x2);
			pat_checkStructurePre.edgeToTargetNode.Add(checkStructurePre_edge__edge1, checkStructurePre_node_x4);
			pat_checkStructurePre.edgeToSourceNode.Add(checkStructurePre_edge__edge2, checkStructurePre_node_x3);
			pat_checkStructurePre.edgeToTargetNode.Add(checkStructurePre_edge__edge2, checkStructurePre_node_x4);

			checkStructurePre_node_x1.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_node_x4.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_node_x2.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_node_x3.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_edge__edge0.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_edge__edge1.pointOfDefinition = pat_checkStructurePre;
			checkStructurePre_edge__edge2.pointOfDefinition = pat_checkStructurePre;

			patternGraph = pat_checkStructurePre;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_checkStructurePre curMatch = (Match_checkStructurePre)_curMatch;
			return;
		}

		static Rule_checkStructurePre() {
		}

		public interface IMatch_checkStructurePre : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IEmployee node_x1 { get; }
			GRGEN_MODEL.IEmployee node_x4 { get; }
			GRGEN_MODEL.IEmployee node_x2 { get; }
			GRGEN_MODEL.IEmployee node_x3 { get; }
			//Edges
			GRGEN_MODEL.IManagedBy edge__edge0 { get; }
			GRGEN_MODEL.IManagedBy edge__edge1 { get; }
			GRGEN_MODEL.IManagedBy edge__edge2 { get; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_checkStructurePre : GRGEN_LGSP.ListElement<Match_checkStructurePre>, IMatch_checkStructurePre
		{
			public GRGEN_MODEL.IEmployee node_x1 { get { return (GRGEN_MODEL.IEmployee)_node_x1; } }
			public GRGEN_MODEL.IEmployee node_x4 { get { return (GRGEN_MODEL.IEmployee)_node_x4; } }
			public GRGEN_MODEL.IEmployee node_x2 { get { return (GRGEN_MODEL.IEmployee)_node_x2; } }
			public GRGEN_MODEL.IEmployee node_x3 { get { return (GRGEN_MODEL.IEmployee)_node_x3; } }
			public GRGEN_LGSP.LGSPNode _node_x1;
			public GRGEN_LGSP.LGSPNode _node_x4;
			public GRGEN_LGSP.LGSPNode _node_x2;
			public GRGEN_LGSP.LGSPNode _node_x3;
			public enum checkStructurePre_NodeNums { @x1, @x4, @x2, @x3, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public int NumberOfNodes { get { return 4;} }
			public GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)checkStructurePre_NodeNums.@x1: return _node_x1;
				case (int)checkStructurePre_NodeNums.@x4: return _node_x4;
				case (int)checkStructurePre_NodeNums.@x2: return _node_x2;
				case (int)checkStructurePre_NodeNums.@x3: return _node_x3;
				default: return null;
				}
			}
			
			public GRGEN_MODEL.IManagedBy edge__edge0 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge0; } }
			public GRGEN_MODEL.IManagedBy edge__edge1 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge1; } }
			public GRGEN_MODEL.IManagedBy edge__edge2 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge2; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public GRGEN_LGSP.LGSPEdge _edge__edge2;
			public enum checkStructurePre_EdgeNums { @_edge0, @_edge1, @_edge2, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public int NumberOfEdges { get { return 3;} }
			public GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)checkStructurePre_EdgeNums.@_edge0: return _edge__edge0;
				case (int)checkStructurePre_EdgeNums.@_edge1: return _edge__edge1;
				case (int)checkStructurePre_EdgeNums.@_edge2: return _edge__edge2;
				default: return null;
				}
			}
			
			public enum checkStructurePre_VariableNums { END_OF_ENUM };
			public IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public int NumberOfVariables { get { return 0;} }
			public object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePre_SubNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public int NumberOfEmbeddedGraphs { get { return 0;} }
			public GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePre_AltNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public int NumberOfAlternatives { get { return 0;} }
			public GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePre_IterNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public int NumberOfIterateds { get { return 0;} }
			public GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePre_IdptNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public int NumberOfIndependents { get { return 0;} }
			public GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_checkStructurePre.instance.pat_checkStructurePre; } }
			public GRGEN_LIBGR.IMatch MatchOfEnclosingPattern { get { return _matchOfEnclosingPattern; } }
			public GRGEN_LIBGR.IMatch Clone() { return new Match_checkStructurePre(this); }
			public GRGEN_LIBGR.IMatch _matchOfEnclosingPattern;
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public override string ToString() { return "Match of " + Pattern.Name; }

			public Match_checkStructurePre(Match_checkStructurePre that)
			{
				_node_x1 = that._node_x1;
				_node_x4 = that._node_x4;
				_node_x2 = that._node_x2;
				_node_x3 = that._node_x3;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				_edge__edge2 = that._edge__edge2;
			}
			public Match_checkStructurePre()
			{
			}
		}

	}

	public class Rule_checkStructurePost : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_checkStructurePost instance = null;
		public static Rule_checkStructurePost Instance { get { if (instance==null) { instance = new Rule_checkStructurePost(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] checkStructurePost_node_x4_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePost_node_x1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePost_node_x3_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] checkStructurePost_node_x2_AllowedTypes = null;
		public static bool[] checkStructurePost_node_x4_IsAllowedType = null;
		public static bool[] checkStructurePost_node_x1_IsAllowedType = null;
		public static bool[] checkStructurePost_node_x3_IsAllowedType = null;
		public static bool[] checkStructurePost_node_x2_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePost_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePost_edge__edge1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] checkStructurePost_edge__edge2_AllowedTypes = null;
		public static bool[] checkStructurePost_edge__edge0_IsAllowedType = null;
		public static bool[] checkStructurePost_edge__edge1_IsAllowedType = null;
		public static bool[] checkStructurePost_edge__edge2_IsAllowedType = null;
		public enum checkStructurePost_NodeNums { @x4, @x1, @x3, @x2, };
		public enum checkStructurePost_EdgeNums { @_edge0, @_edge1, @_edge2, };
		public enum checkStructurePost_VariableNums { };
		public enum checkStructurePost_SubNums { };
		public enum checkStructurePost_AltNums { };
		public enum checkStructurePost_IterNums { };



		public GRGEN_LGSP.PatternGraph pat_checkStructurePost;


		private Rule_checkStructurePost()
		{
			name = "checkStructurePost";

			inputs = new GRGEN_LIBGR.GrGenType[] { };
			inputNames = new string[] { };
			defs = new GRGEN_LIBGR.GrGenType[] { };
			defNames = new string[] { };
			outputs = new GRGEN_LIBGR.GrGenType[] { };

		}
		private void initialize()
		{
			bool[,] checkStructurePost_isNodeHomomorphicGlobal = new bool[4, 4] {
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
			};
			bool[,] checkStructurePost_isEdgeHomomorphicGlobal = new bool[3, 3] {
				{ false, false, false, },
				{ false, false, false, },
				{ false, false, false, },
			};
			bool[] checkStructurePost_isNodeTotallyHomomorphic = new bool[4] { false, false, false, false,  };
			bool[] checkStructurePost_isEdgeTotallyHomomorphic = new bool[3] { false, false, false,  };
			GRGEN_LGSP.PatternNode checkStructurePost_node_x4 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePost_node_x4", "x4", checkStructurePost_node_x4_AllowedTypes, checkStructurePost_node_x4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePost_node_x1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePost_node_x1", "x1", checkStructurePost_node_x1_AllowedTypes, checkStructurePost_node_x1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePost_node_x3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePost_node_x3", "x3", checkStructurePost_node_x3_AllowedTypes, checkStructurePost_node_x3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode checkStructurePost_node_x2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "checkStructurePost_node_x2", "x2", checkStructurePost_node_x2_AllowedTypes, checkStructurePost_node_x2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePost_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePost_edge__edge0", "_edge0", checkStructurePost_edge__edge0_AllowedTypes, checkStructurePost_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePost_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePost_edge__edge1", "_edge1", checkStructurePost_edge__edge1_AllowedTypes, checkStructurePost_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge checkStructurePost_edge__edge2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "checkStructurePost_edge__edge2", "_edge2", checkStructurePost_edge__edge2_AllowedTypes, checkStructurePost_edge__edge2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternCondition checkStructurePost_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePost_node_x1", "id"), new GRGEN_EXPR.Constant("1")),
				new string[] { "checkStructurePost_node_x1" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePost_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePost_node_x2", "id"), new GRGEN_EXPR.Constant("2")),
				new string[] { "checkStructurePost_node_x2" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePost_cond_2 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePost_node_x3", "id"), new GRGEN_EXPR.Constant("3")),
				new string[] { "checkStructurePost_node_x3" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition checkStructurePost_cond_3 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "checkStructurePost_node_x4", "id"), new GRGEN_EXPR.Constant("4")),
				new string[] { "checkStructurePost_node_x4" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			pat_checkStructurePost = new GRGEN_LGSP.PatternGraph(
				"checkStructurePost",
				"",
				false, false,
				new GRGEN_LGSP.PatternNode[] { checkStructurePost_node_x4, checkStructurePost_node_x1, checkStructurePost_node_x3, checkStructurePost_node_x2 }, 
				new GRGEN_LGSP.PatternEdge[] { checkStructurePost_edge__edge0, checkStructurePost_edge__edge1, checkStructurePost_edge__edge2 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { checkStructurePost_cond_0, checkStructurePost_cond_1, checkStructurePost_cond_2, checkStructurePost_cond_3,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[4, 4] {
					{ true, false, false, false, },
					{ false, true, false, false, },
					{ false, false, true, false, },
					{ false, false, false, true, },
				},
				new bool[3, 3] {
					{ true, false, false, },
					{ false, true, false, },
					{ false, false, true, },
				},
				checkStructurePost_isNodeHomomorphicGlobal,
				checkStructurePost_isEdgeHomomorphicGlobal,
				checkStructurePost_isNodeTotallyHomomorphic,
				checkStructurePost_isEdgeTotallyHomomorphic
			);
			pat_checkStructurePost.edgeToSourceNode.Add(checkStructurePost_edge__edge0, checkStructurePost_node_x4);
			pat_checkStructurePost.edgeToTargetNode.Add(checkStructurePost_edge__edge0, checkStructurePost_node_x1);
			pat_checkStructurePost.edgeToSourceNode.Add(checkStructurePost_edge__edge1, checkStructurePost_node_x3);
			pat_checkStructurePost.edgeToTargetNode.Add(checkStructurePost_edge__edge1, checkStructurePost_node_x1);
			pat_checkStructurePost.edgeToSourceNode.Add(checkStructurePost_edge__edge2, checkStructurePost_node_x2);
			pat_checkStructurePost.edgeToTargetNode.Add(checkStructurePost_edge__edge2, checkStructurePost_node_x1);

			checkStructurePost_node_x4.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_node_x1.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_node_x3.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_node_x2.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_edge__edge0.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_edge__edge1.pointOfDefinition = pat_checkStructurePost;
			checkStructurePost_edge__edge2.pointOfDefinition = pat_checkStructurePost;

			patternGraph = pat_checkStructurePost;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_checkStructurePost curMatch = (Match_checkStructurePost)_curMatch;
			return;
		}

		static Rule_checkStructurePost() {
		}

		public interface IMatch_checkStructurePost : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IEmployee node_x4 { get; }
			GRGEN_MODEL.IEmployee node_x1 { get; }
			GRGEN_MODEL.IEmployee node_x3 { get; }
			GRGEN_MODEL.IEmployee node_x2 { get; }
			//Edges
			GRGEN_MODEL.IManagedBy edge__edge0 { get; }
			GRGEN_MODEL.IManagedBy edge__edge1 { get; }
			GRGEN_MODEL.IManagedBy edge__edge2 { get; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_checkStructurePost : GRGEN_LGSP.ListElement<Match_checkStructurePost>, IMatch_checkStructurePost
		{
			public GRGEN_MODEL.IEmployee node_x4 { get { return (GRGEN_MODEL.IEmployee)_node_x4; } }
			public GRGEN_MODEL.IEmployee node_x1 { get { return (GRGEN_MODEL.IEmployee)_node_x1; } }
			public GRGEN_MODEL.IEmployee node_x3 { get { return (GRGEN_MODEL.IEmployee)_node_x3; } }
			public GRGEN_MODEL.IEmployee node_x2 { get { return (GRGEN_MODEL.IEmployee)_node_x2; } }
			public GRGEN_LGSP.LGSPNode _node_x4;
			public GRGEN_LGSP.LGSPNode _node_x1;
			public GRGEN_LGSP.LGSPNode _node_x3;
			public GRGEN_LGSP.LGSPNode _node_x2;
			public enum checkStructurePost_NodeNums { @x4, @x1, @x3, @x2, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public int NumberOfNodes { get { return 4;} }
			public GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)checkStructurePost_NodeNums.@x4: return _node_x4;
				case (int)checkStructurePost_NodeNums.@x1: return _node_x1;
				case (int)checkStructurePost_NodeNums.@x3: return _node_x3;
				case (int)checkStructurePost_NodeNums.@x2: return _node_x2;
				default: return null;
				}
			}
			
			public GRGEN_MODEL.IManagedBy edge__edge0 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge0; } }
			public GRGEN_MODEL.IManagedBy edge__edge1 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge1; } }
			public GRGEN_MODEL.IManagedBy edge__edge2 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge2; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public GRGEN_LGSP.LGSPEdge _edge__edge2;
			public enum checkStructurePost_EdgeNums { @_edge0, @_edge1, @_edge2, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public int NumberOfEdges { get { return 3;} }
			public GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)checkStructurePost_EdgeNums.@_edge0: return _edge__edge0;
				case (int)checkStructurePost_EdgeNums.@_edge1: return _edge__edge1;
				case (int)checkStructurePost_EdgeNums.@_edge2: return _edge__edge2;
				default: return null;
				}
			}
			
			public enum checkStructurePost_VariableNums { END_OF_ENUM };
			public IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public int NumberOfVariables { get { return 0;} }
			public object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePost_SubNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public int NumberOfEmbeddedGraphs { get { return 0;} }
			public GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePost_AltNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public int NumberOfAlternatives { get { return 0;} }
			public GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePost_IterNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public int NumberOfIterateds { get { return 0;} }
			public GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum checkStructurePost_IdptNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public int NumberOfIndependents { get { return 0;} }
			public GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_checkStructurePost.instance.pat_checkStructurePost; } }
			public GRGEN_LIBGR.IMatch MatchOfEnclosingPattern { get { return _matchOfEnclosingPattern; } }
			public GRGEN_LIBGR.IMatch Clone() { return new Match_checkStructurePost(this); }
			public GRGEN_LIBGR.IMatch _matchOfEnclosingPattern;
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public override string ToString() { return "Match of " + Pattern.Name; }

			public Match_checkStructurePost(Match_checkStructurePost that)
			{
				_node_x4 = that._node_x4;
				_node_x1 = that._node_x1;
				_node_x3 = that._node_x3;
				_node_x2 = that._node_x2;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				_edge__edge2 = that._edge__edge2;
			}
			public Match_checkStructurePost()
			{
			}
		}

	}

	public class Rule_replaceBadManager : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_replaceBadManager instance = null;
		public static Rule_replaceBadManager Instance { get { if (instance==null) { instance = new Rule_replaceBadManager(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] replaceBadManager_node_x1_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] replaceBadManager_node_x4_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] replaceBadManager_node_x2_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] replaceBadManager_node_x3_AllowedTypes = null;
		public static bool[] replaceBadManager_node_x1_IsAllowedType = null;
		public static bool[] replaceBadManager_node_x4_IsAllowedType = null;
		public static bool[] replaceBadManager_node_x2_IsAllowedType = null;
		public static bool[] replaceBadManager_node_x3_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] replaceBadManager_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] replaceBadManager_edge__edge1_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] replaceBadManager_edge__edge2_AllowedTypes = null;
		public static bool[] replaceBadManager_edge__edge0_IsAllowedType = null;
		public static bool[] replaceBadManager_edge__edge1_IsAllowedType = null;
		public static bool[] replaceBadManager_edge__edge2_IsAllowedType = null;
		public enum replaceBadManager_NodeNums { @x1, @x4, @x2, @x3, };
		public enum replaceBadManager_EdgeNums { @_edge0, @_edge1, @_edge2, };
		public enum replaceBadManager_VariableNums { };
		public enum replaceBadManager_SubNums { };
		public enum replaceBadManager_AltNums { };
		public enum replaceBadManager_IterNums { };




		public GRGEN_LGSP.PatternGraph pat_replaceBadManager;


		private Rule_replaceBadManager()
		{
			name = "replaceBadManager";

			inputs = new GRGEN_LIBGR.GrGenType[] { };
			inputNames = new string[] { };
			defs = new GRGEN_LIBGR.GrGenType[] { };
			defNames = new string[] { };
			outputs = new GRGEN_LIBGR.GrGenType[] { };

		}
		private void initialize()
		{
			bool[,] replaceBadManager_isNodeHomomorphicGlobal = new bool[4, 4] {
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
				{ false, false, false, false, },
			};
			bool[,] replaceBadManager_isEdgeHomomorphicGlobal = new bool[3, 3] {
				{ false, false, false, },
				{ false, false, false, },
				{ false, false, false, },
			};
			bool[] replaceBadManager_isNodeTotallyHomomorphic = new bool[4] { false, false, false, false,  };
			bool[] replaceBadManager_isEdgeTotallyHomomorphic = new bool[3] { false, false, false,  };
			GRGEN_LGSP.PatternNode replaceBadManager_node_x1 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "replaceBadManager_node_x1", "x1", replaceBadManager_node_x1_AllowedTypes, replaceBadManager_node_x1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode replaceBadManager_node_x4 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "replaceBadManager_node_x4", "x4", replaceBadManager_node_x4_AllowedTypes, replaceBadManager_node_x4_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode replaceBadManager_node_x2 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "replaceBadManager_node_x2", "x2", replaceBadManager_node_x2_AllowedTypes, replaceBadManager_node_x2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternNode replaceBadManager_node_x3 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Employee, "GRGEN_MODEL.IEmployee", "replaceBadManager_node_x3", "x3", replaceBadManager_node_x3_AllowedTypes, replaceBadManager_node_x3_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge replaceBadManager_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "replaceBadManager_edge__edge0", "_edge0", replaceBadManager_edge__edge0_AllowedTypes, replaceBadManager_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge replaceBadManager_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "replaceBadManager_edge__edge1", "_edge1", replaceBadManager_edge__edge1_AllowedTypes, replaceBadManager_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternEdge replaceBadManager_edge__edge2 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@ManagedBy, "GRGEN_MODEL.IManagedBy", "replaceBadManager_edge__edge2", "_edge2", replaceBadManager_edge__edge2_AllowedTypes, replaceBadManager_edge__edge2_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, false);
			GRGEN_LGSP.PatternCondition replaceBadManager_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "replaceBadManager_node_x1", "id"), new GRGEN_EXPR.Constant("1")),
				new string[] { "replaceBadManager_node_x1" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition replaceBadManager_cond_1 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "replaceBadManager_node_x2", "id"), new GRGEN_EXPR.Constant("2")),
				new string[] { "replaceBadManager_node_x2" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition replaceBadManager_cond_2 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "replaceBadManager_node_x3", "id"), new GRGEN_EXPR.Constant("3")),
				new string[] { "replaceBadManager_node_x3" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			GRGEN_LGSP.PatternCondition replaceBadManager_cond_3 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IEmployee", "replaceBadManager_node_x4", "id"), new GRGEN_EXPR.Constant("4")),
				new string[] { "replaceBadManager_node_x4" }, new string[] {  }, new string[] {  }, new GRGEN_LIBGR.VarType[] {  });
			pat_replaceBadManager = new GRGEN_LGSP.PatternGraph(
				"replaceBadManager",
				"",
				false, false,
				new GRGEN_LGSP.PatternNode[] { replaceBadManager_node_x1, replaceBadManager_node_x4, replaceBadManager_node_x2, replaceBadManager_node_x3 }, 
				new GRGEN_LGSP.PatternEdge[] { replaceBadManager_edge__edge0, replaceBadManager_edge__edge1, replaceBadManager_edge__edge2 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { replaceBadManager_cond_0, replaceBadManager_cond_1, replaceBadManager_cond_2, replaceBadManager_cond_3,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[4, 4] {
					{ true, false, false, false, },
					{ false, true, false, false, },
					{ false, false, true, false, },
					{ false, false, false, true, },
				},
				new bool[3, 3] {
					{ true, false, false, },
					{ false, true, false, },
					{ false, false, true, },
				},
				replaceBadManager_isNodeHomomorphicGlobal,
				replaceBadManager_isEdgeHomomorphicGlobal,
				replaceBadManager_isNodeTotallyHomomorphic,
				replaceBadManager_isEdgeTotallyHomomorphic
			);
			pat_replaceBadManager.edgeToSourceNode.Add(replaceBadManager_edge__edge0, replaceBadManager_node_x1);
			pat_replaceBadManager.edgeToTargetNode.Add(replaceBadManager_edge__edge0, replaceBadManager_node_x4);
			pat_replaceBadManager.edgeToSourceNode.Add(replaceBadManager_edge__edge1, replaceBadManager_node_x2);
			pat_replaceBadManager.edgeToTargetNode.Add(replaceBadManager_edge__edge1, replaceBadManager_node_x4);
			pat_replaceBadManager.edgeToSourceNode.Add(replaceBadManager_edge__edge2, replaceBadManager_node_x3);
			pat_replaceBadManager.edgeToTargetNode.Add(replaceBadManager_edge__edge2, replaceBadManager_node_x4);

			replaceBadManager_node_x1.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_node_x4.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_node_x2.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_node_x3.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_edge__edge0.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_edge__edge1.pointOfDefinition = pat_replaceBadManager;
			replaceBadManager_edge__edge2.pointOfDefinition = pat_replaceBadManager;

			patternGraph = pat_replaceBadManager;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_replaceBadManager curMatch = (Match_replaceBadManager)_curMatch;
			GRGEN_LGSP.LGSPNode node_x4 = curMatch._node_x4;
			GRGEN_LGSP.LGSPNode node_x1 = curMatch._node_x1;
			GRGEN_LGSP.LGSPNode node_x3 = curMatch._node_x3;
			GRGEN_LGSP.LGSPNode node_x2 = curMatch._node_x2;
			graph.SettingAddedNodeNames( replaceBadManager_addedNodeNames );
			graph.SettingAddedEdgeNames( replaceBadManager_addedEdgeNames );
			GRGEN_MODEL.@ManagedBy edge__edge3 = GRGEN_MODEL.@ManagedBy.CreateEdge(graph, node_x4, node_x1);
			GRGEN_MODEL.@ManagedBy edge__edge4 = GRGEN_MODEL.@ManagedBy.CreateEdge(graph, node_x3, node_x1);
			GRGEN_MODEL.@ManagedBy edge__edge5 = GRGEN_MODEL.@ManagedBy.CreateEdge(graph, node_x2, node_x1);
			return;
		}
		private static string[] replaceBadManager_addedNodeNames = new string[] {  };
		private static string[] replaceBadManager_addedEdgeNames = new string[] { "_edge3", "_edge4", "_edge5" };

		static Rule_replaceBadManager() {
		}

		public interface IMatch_replaceBadManager : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IEmployee node_x1 { get; }
			GRGEN_MODEL.IEmployee node_x4 { get; }
			GRGEN_MODEL.IEmployee node_x2 { get; }
			GRGEN_MODEL.IEmployee node_x3 { get; }
			//Edges
			GRGEN_MODEL.IManagedBy edge__edge0 { get; }
			GRGEN_MODEL.IManagedBy edge__edge1 { get; }
			GRGEN_MODEL.IManagedBy edge__edge2 { get; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_replaceBadManager : GRGEN_LGSP.ListElement<Match_replaceBadManager>, IMatch_replaceBadManager
		{
			public GRGEN_MODEL.IEmployee node_x1 { get { return (GRGEN_MODEL.IEmployee)_node_x1; } }
			public GRGEN_MODEL.IEmployee node_x4 { get { return (GRGEN_MODEL.IEmployee)_node_x4; } }
			public GRGEN_MODEL.IEmployee node_x2 { get { return (GRGEN_MODEL.IEmployee)_node_x2; } }
			public GRGEN_MODEL.IEmployee node_x3 { get { return (GRGEN_MODEL.IEmployee)_node_x3; } }
			public GRGEN_LGSP.LGSPNode _node_x1;
			public GRGEN_LGSP.LGSPNode _node_x4;
			public GRGEN_LGSP.LGSPNode _node_x2;
			public GRGEN_LGSP.LGSPNode _node_x3;
			public enum replaceBadManager_NodeNums { @x1, @x4, @x2, @x3, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public int NumberOfNodes { get { return 4;} }
			public GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)replaceBadManager_NodeNums.@x1: return _node_x1;
				case (int)replaceBadManager_NodeNums.@x4: return _node_x4;
				case (int)replaceBadManager_NodeNums.@x2: return _node_x2;
				case (int)replaceBadManager_NodeNums.@x3: return _node_x3;
				default: return null;
				}
			}
			
			public GRGEN_MODEL.IManagedBy edge__edge0 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge0; } }
			public GRGEN_MODEL.IManagedBy edge__edge1 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge1; } }
			public GRGEN_MODEL.IManagedBy edge__edge2 { get { return (GRGEN_MODEL.IManagedBy)_edge__edge2; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public GRGEN_LGSP.LGSPEdge _edge__edge2;
			public enum replaceBadManager_EdgeNums { @_edge0, @_edge1, @_edge2, END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public int NumberOfEdges { get { return 3;} }
			public GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)replaceBadManager_EdgeNums.@_edge0: return _edge__edge0;
				case (int)replaceBadManager_EdgeNums.@_edge1: return _edge__edge1;
				case (int)replaceBadManager_EdgeNums.@_edge2: return _edge__edge2;
				default: return null;
				}
			}
			
			public enum replaceBadManager_VariableNums { END_OF_ENUM };
			public IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public int NumberOfVariables { get { return 0;} }
			public object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum replaceBadManager_SubNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public int NumberOfEmbeddedGraphs { get { return 0;} }
			public GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum replaceBadManager_AltNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public int NumberOfAlternatives { get { return 0;} }
			public GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum replaceBadManager_IterNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public int NumberOfIterateds { get { return 0;} }
			public GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public enum replaceBadManager_IdptNums { END_OF_ENUM };
			public IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public int NumberOfIndependents { get { return 0;} }
			public GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			
			public GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_replaceBadManager.instance.pat_replaceBadManager; } }
			public GRGEN_LIBGR.IMatch MatchOfEnclosingPattern { get { return _matchOfEnclosingPattern; } }
			public GRGEN_LIBGR.IMatch Clone() { return new Match_replaceBadManager(this); }
			public GRGEN_LIBGR.IMatch _matchOfEnclosingPattern;
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public override string ToString() { return "Match of " + Pattern.Name; }

			public Match_replaceBadManager(Match_replaceBadManager that)
			{
				_node_x1 = that._node_x1;
				_node_x4 = that._node_x4;
				_node_x2 = that._node_x2;
				_node_x3 = that._node_x3;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
				_edge__edge2 = that._edge__edge2;
			}
			public Match_replaceBadManager()
			{
			}
		}

	}

	public class ReplaceManager_RuleAndMatchingPatterns : GRGEN_LGSP.LGSPRuleAndMatchingPatterns
	{
		public ReplaceManager_RuleAndMatchingPatterns()
		{
			subpatterns = new GRGEN_LGSP.LGSPMatchingPattern[0];
			rules = new GRGEN_LGSP.LGSPRulePattern[3];
			rulesAndSubpatterns = new GRGEN_LGSP.LGSPMatchingPattern[0+3];
			definedSequences = new GRGEN_LIBGR.DefinedSequenceInfo[0];
			rules[0] = Rule_checkStructurePre.Instance;
			rulesAndSubpatterns[0+0] = Rule_checkStructurePre.Instance;
			rules[1] = Rule_checkStructurePost.Instance;
			rulesAndSubpatterns[0+1] = Rule_checkStructurePost.Instance;
			rules[2] = Rule_replaceBadManager.Instance;
			rulesAndSubpatterns[0+2] = Rule_replaceBadManager.Instance;
		}
		public override GRGEN_LGSP.LGSPRulePattern[] Rules { get { return rules; } }
		private GRGEN_LGSP.LGSPRulePattern[] rules;
		public override GRGEN_LGSP.LGSPMatchingPattern[] Subpatterns { get { return subpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] subpatterns;
		public override GRGEN_LGSP.LGSPMatchingPattern[] RulesAndSubpatterns { get { return rulesAndSubpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] rulesAndSubpatterns;
		public override GRGEN_LIBGR.DefinedSequenceInfo[] DefinedSequences { get { return definedSequences; } }
		private GRGEN_LIBGR.DefinedSequenceInfo[] definedSequences;
	}


    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_checkStructurePre
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_checkStructurePre.IMatch_checkStructurePre match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns true if applied at least once. </summary>
        bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_checkStructurePre : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_checkStructurePre
    {
        public Action_checkStructurePre() {
            _rulePattern = Rule_checkStructurePre.Instance;
            patternGraph = _rulePattern.patternGraph;
            DynamicMatch = myMatch;
            ReturnArray = new object[0];
            matches = new GRGEN_LGSP.LGSPMatchesList<Rule_checkStructurePre.Match_checkStructurePre, Rule_checkStructurePre.IMatch_checkStructurePre>(this);
        }

        public Rule_checkStructurePre _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "checkStructurePre"; } }
        private GRGEN_LGSP.LGSPMatchesList<Rule_checkStructurePre.Match_checkStructurePre, Rule_checkStructurePre.IMatch_checkStructurePre> matches;

        public static Action_checkStructurePre Instance { get { return instance; } }
        private static Action_checkStructurePre instance = new Action_checkStructurePre();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            matches.Clear();
            int negLevel = 0;
            // Lookup checkStructurePre_edge__edge0 
            int type_id_candidate_checkStructurePre_edge__edge0 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePre_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_checkStructurePre_edge__edge0], candidate_checkStructurePre_edge__edge0 = head_candidate_checkStructurePre_edge__edge0.lgspTypeNext; candidate_checkStructurePre_edge__edge0 != head_candidate_checkStructurePre_edge__edge0; candidate_checkStructurePre_edge__edge0 = candidate_checkStructurePre_edge__edge0.lgspTypeNext)
            {
                uint prev__candidate_checkStructurePre_edge__edge0;
                prev__candidate_checkStructurePre_edge__edge0 = candidate_checkStructurePre_edge__edge0.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePre_edge__edge0.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Implicit Source checkStructurePre_node_x1 from checkStructurePre_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_checkStructurePre_node_x1 = candidate_checkStructurePre_edge__edge0.lgspSource;
                if(candidate_checkStructurePre_node_x1.lgspType.TypeID!=1) {
                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                    continue;
                }
                uint prev__candidate_checkStructurePre_node_x1;
                prev__candidate_checkStructurePre_node_x1 = candidate_checkStructurePre_node_x1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePre_node_x1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePre_node_x1).@id == 1))) {
                    candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                    continue;
                }
                // Implicit Target checkStructurePre_node_x4 from checkStructurePre_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_checkStructurePre_node_x4 = candidate_checkStructurePre_edge__edge0.lgspTarget;
                if(candidate_checkStructurePre_node_x4.lgspType.TypeID!=1) {
                    candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                    continue;
                }
                if((candidate_checkStructurePre_node_x4.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                {
                    candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                    continue;
                }
                uint prev__candidate_checkStructurePre_node_x4;
                prev__candidate_checkStructurePre_node_x4 = candidate_checkStructurePre_node_x4.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePre_node_x4.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePre_node_x4).@id == 4))) {
                    candidate_checkStructurePre_node_x4.lgspFlags = candidate_checkStructurePre_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x4;
                    candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                    continue;
                }
                // Extend Incoming checkStructurePre_edge__edge1 from checkStructurePre_node_x4 
                GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePre_edge__edge1 = candidate_checkStructurePre_node_x4.lgspInhead;
                if(head_candidate_checkStructurePre_edge__edge1 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_checkStructurePre_edge__edge1 = head_candidate_checkStructurePre_edge__edge1;
                    do
                    {
                        if(candidate_checkStructurePre_edge__edge1.lgspType.TypeID!=3) {
                            continue;
                        }
                        if((candidate_checkStructurePre_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            continue;
                        }
                        uint prev__candidate_checkStructurePre_edge__edge1;
                        prev__candidate_checkStructurePre_edge__edge1 = candidate_checkStructurePre_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_checkStructurePre_edge__edge1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Implicit Source checkStructurePre_node_x2 from checkStructurePre_edge__edge1 
                        GRGEN_LGSP.LGSPNode candidate_checkStructurePre_node_x2 = candidate_checkStructurePre_edge__edge1.lgspSource;
                        if(candidate_checkStructurePre_node_x2.lgspType.TypeID!=1) {
                            candidate_checkStructurePre_edge__edge1.lgspFlags = candidate_checkStructurePre_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge1;
                            continue;
                        }
                        if((candidate_checkStructurePre_node_x2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            candidate_checkStructurePre_edge__edge1.lgspFlags = candidate_checkStructurePre_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge1;
                            continue;
                        }
                        uint prev__candidate_checkStructurePre_node_x2;
                        prev__candidate_checkStructurePre_node_x2 = candidate_checkStructurePre_node_x2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_checkStructurePre_node_x2.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Condition 
                        if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePre_node_x2).@id == 2))) {
                            candidate_checkStructurePre_node_x2.lgspFlags = candidate_checkStructurePre_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x2;
                            candidate_checkStructurePre_edge__edge1.lgspFlags = candidate_checkStructurePre_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge1;
                            continue;
                        }
                        // Extend Incoming checkStructurePre_edge__edge2 from checkStructurePre_node_x4 
                        GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePre_edge__edge2 = candidate_checkStructurePre_node_x4.lgspInhead;
                        if(head_candidate_checkStructurePre_edge__edge2 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_checkStructurePre_edge__edge2 = head_candidate_checkStructurePre_edge__edge2;
                            do
                            {
                                if(candidate_checkStructurePre_edge__edge2.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_checkStructurePre_edge__edge2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Implicit Source checkStructurePre_node_x3 from checkStructurePre_edge__edge2 
                                GRGEN_LGSP.LGSPNode candidate_checkStructurePre_node_x3 = candidate_checkStructurePre_edge__edge2.lgspSource;
                                if(candidate_checkStructurePre_node_x3.lgspType.TypeID!=1) {
                                    continue;
                                }
                                if((candidate_checkStructurePre_node_x3.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Condition 
                                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePre_node_x3).@id == 3))) {
                                    continue;
                                }
                                Rule_checkStructurePre.Match_checkStructurePre match = matches.GetNextUnfilledPosition();
                                match._node_x1 = candidate_checkStructurePre_node_x1;
                                match._node_x4 = candidate_checkStructurePre_node_x4;
                                match._node_x2 = candidate_checkStructurePre_node_x2;
                                match._node_x3 = candidate_checkStructurePre_node_x3;
                                match._edge__edge0 = candidate_checkStructurePre_edge__edge0;
                                match._edge__edge1 = candidate_checkStructurePre_edge__edge1;
                                match._edge__edge2 = candidate_checkStructurePre_edge__edge2;
                                matches.PositionWasFilledFixIt();
                                // if enough matches were found, we leave
                                if(maxMatches > 0 && matches.Count >= maxMatches)
                                {
                                    candidate_checkStructurePre_node_x4.MoveInHeadAfter(candidate_checkStructurePre_edge__edge2);
                                    candidate_checkStructurePre_node_x4.MoveInHeadAfter(candidate_checkStructurePre_edge__edge1);
                                    graph.MoveHeadAfter(candidate_checkStructurePre_edge__edge0);
                                    candidate_checkStructurePre_node_x2.lgspFlags = candidate_checkStructurePre_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x2;
                                    candidate_checkStructurePre_edge__edge1.lgspFlags = candidate_checkStructurePre_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge1;
                                    candidate_checkStructurePre_node_x4.lgspFlags = candidate_checkStructurePre_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x4;
                                    candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                                    candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
                                    return matches;
                                }
                            }
                            while( (candidate_checkStructurePre_edge__edge2 = candidate_checkStructurePre_edge__edge2.lgspInNext) != head_candidate_checkStructurePre_edge__edge2 );
                        }
                        candidate_checkStructurePre_node_x2.lgspFlags = candidate_checkStructurePre_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x2;
                        candidate_checkStructurePre_edge__edge1.lgspFlags = candidate_checkStructurePre_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge1;
                    }
                    while( (candidate_checkStructurePre_edge__edge1 = candidate_checkStructurePre_edge__edge1.lgspInNext) != head_candidate_checkStructurePre_edge__edge1 );
                }
                candidate_checkStructurePre_node_x4.lgspFlags = candidate_checkStructurePre_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x4;
                candidate_checkStructurePre_node_x1.lgspFlags = candidate_checkStructurePre_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_node_x1;
                candidate_checkStructurePre_edge__edge0.lgspFlags = candidate_checkStructurePre_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePre_edge__edge0;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_checkStructurePre.IMatch_checkStructurePre match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches)
        {
            foreach(Rule_checkStructurePre.IMatch_checkStructurePre match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return false;
            foreach(Rule_checkStructurePre.IMatch_checkStructurePre match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            return true;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_checkStructurePre.IMatch_checkStructurePre)match);
            return ReturnArray;
        }
        public object[] ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePre.IMatch_checkStructurePre>)matches);
            return ReturnArray;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
    }

    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_checkStructurePost
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_checkStructurePost.IMatch_checkStructurePost match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns true if applied at least once. </summary>
        bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_checkStructurePost : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_checkStructurePost
    {
        public Action_checkStructurePost() {
            _rulePattern = Rule_checkStructurePost.Instance;
            patternGraph = _rulePattern.patternGraph;
            DynamicMatch = myMatch;
            ReturnArray = new object[0];
            matches = new GRGEN_LGSP.LGSPMatchesList<Rule_checkStructurePost.Match_checkStructurePost, Rule_checkStructurePost.IMatch_checkStructurePost>(this);
        }

        public Rule_checkStructurePost _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "checkStructurePost"; } }
        private GRGEN_LGSP.LGSPMatchesList<Rule_checkStructurePost.Match_checkStructurePost, Rule_checkStructurePost.IMatch_checkStructurePost> matches;

        public static Action_checkStructurePost Instance { get { return instance; } }
        private static Action_checkStructurePost instance = new Action_checkStructurePost();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            matches.Clear();
            int negLevel = 0;
            // Lookup checkStructurePost_edge__edge0 
            int type_id_candidate_checkStructurePost_edge__edge0 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePost_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_checkStructurePost_edge__edge0], candidate_checkStructurePost_edge__edge0 = head_candidate_checkStructurePost_edge__edge0.lgspTypeNext; candidate_checkStructurePost_edge__edge0 != head_candidate_checkStructurePost_edge__edge0; candidate_checkStructurePost_edge__edge0 = candidate_checkStructurePost_edge__edge0.lgspTypeNext)
            {
                uint prev__candidate_checkStructurePost_edge__edge0;
                prev__candidate_checkStructurePost_edge__edge0 = candidate_checkStructurePost_edge__edge0.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePost_edge__edge0.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Implicit Source checkStructurePost_node_x4 from checkStructurePost_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_checkStructurePost_node_x4 = candidate_checkStructurePost_edge__edge0.lgspSource;
                if(candidate_checkStructurePost_node_x4.lgspType.TypeID!=1) {
                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                    continue;
                }
                uint prev__candidate_checkStructurePost_node_x4;
                prev__candidate_checkStructurePost_node_x4 = candidate_checkStructurePost_node_x4.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePost_node_x4.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePost_node_x4).@id == 4))) {
                    candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                    continue;
                }
                // Implicit Target checkStructurePost_node_x1 from checkStructurePost_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_checkStructurePost_node_x1 = candidate_checkStructurePost_edge__edge0.lgspTarget;
                if(candidate_checkStructurePost_node_x1.lgspType.TypeID!=1) {
                    candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                    continue;
                }
                if((candidate_checkStructurePost_node_x1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                {
                    candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                    continue;
                }
                uint prev__candidate_checkStructurePost_node_x1;
                prev__candidate_checkStructurePost_node_x1 = candidate_checkStructurePost_node_x1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_checkStructurePost_node_x1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePost_node_x1).@id == 1))) {
                    candidate_checkStructurePost_node_x1.lgspFlags = candidate_checkStructurePost_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x1;
                    candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                    continue;
                }
                // Extend Incoming checkStructurePost_edge__edge1 from checkStructurePost_node_x1 
                GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePost_edge__edge1 = candidate_checkStructurePost_node_x1.lgspInhead;
                if(head_candidate_checkStructurePost_edge__edge1 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_checkStructurePost_edge__edge1 = head_candidate_checkStructurePost_edge__edge1;
                    do
                    {
                        if(candidate_checkStructurePost_edge__edge1.lgspType.TypeID!=3) {
                            continue;
                        }
                        if((candidate_checkStructurePost_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            continue;
                        }
                        uint prev__candidate_checkStructurePost_edge__edge1;
                        prev__candidate_checkStructurePost_edge__edge1 = candidate_checkStructurePost_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_checkStructurePost_edge__edge1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Implicit Source checkStructurePost_node_x3 from checkStructurePost_edge__edge1 
                        GRGEN_LGSP.LGSPNode candidate_checkStructurePost_node_x3 = candidate_checkStructurePost_edge__edge1.lgspSource;
                        if(candidate_checkStructurePost_node_x3.lgspType.TypeID!=1) {
                            candidate_checkStructurePost_edge__edge1.lgspFlags = candidate_checkStructurePost_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge1;
                            continue;
                        }
                        if((candidate_checkStructurePost_node_x3.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            candidate_checkStructurePost_edge__edge1.lgspFlags = candidate_checkStructurePost_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge1;
                            continue;
                        }
                        uint prev__candidate_checkStructurePost_node_x3;
                        prev__candidate_checkStructurePost_node_x3 = candidate_checkStructurePost_node_x3.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_checkStructurePost_node_x3.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Condition 
                        if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePost_node_x3).@id == 3))) {
                            candidate_checkStructurePost_node_x3.lgspFlags = candidate_checkStructurePost_node_x3.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x3;
                            candidate_checkStructurePost_edge__edge1.lgspFlags = candidate_checkStructurePost_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge1;
                            continue;
                        }
                        // Extend Incoming checkStructurePost_edge__edge2 from checkStructurePost_node_x1 
                        GRGEN_LGSP.LGSPEdge head_candidate_checkStructurePost_edge__edge2 = candidate_checkStructurePost_node_x1.lgspInhead;
                        if(head_candidate_checkStructurePost_edge__edge2 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_checkStructurePost_edge__edge2 = head_candidate_checkStructurePost_edge__edge2;
                            do
                            {
                                if(candidate_checkStructurePost_edge__edge2.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_checkStructurePost_edge__edge2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Implicit Source checkStructurePost_node_x2 from checkStructurePost_edge__edge2 
                                GRGEN_LGSP.LGSPNode candidate_checkStructurePost_node_x2 = candidate_checkStructurePost_edge__edge2.lgspSource;
                                if(candidate_checkStructurePost_node_x2.lgspType.TypeID!=1) {
                                    continue;
                                }
                                if((candidate_checkStructurePost_node_x2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Condition 
                                if(!((((GRGEN_MODEL.IEmployee)candidate_checkStructurePost_node_x2).@id == 2))) {
                                    continue;
                                }
                                Rule_checkStructurePost.Match_checkStructurePost match = matches.GetNextUnfilledPosition();
                                match._node_x4 = candidate_checkStructurePost_node_x4;
                                match._node_x1 = candidate_checkStructurePost_node_x1;
                                match._node_x3 = candidate_checkStructurePost_node_x3;
                                match._node_x2 = candidate_checkStructurePost_node_x2;
                                match._edge__edge0 = candidate_checkStructurePost_edge__edge0;
                                match._edge__edge1 = candidate_checkStructurePost_edge__edge1;
                                match._edge__edge2 = candidate_checkStructurePost_edge__edge2;
                                matches.PositionWasFilledFixIt();
                                // if enough matches were found, we leave
                                if(maxMatches > 0 && matches.Count >= maxMatches)
                                {
                                    candidate_checkStructurePost_node_x1.MoveInHeadAfter(candidate_checkStructurePost_edge__edge2);
                                    candidate_checkStructurePost_node_x1.MoveInHeadAfter(candidate_checkStructurePost_edge__edge1);
                                    graph.MoveHeadAfter(candidate_checkStructurePost_edge__edge0);
                                    candidate_checkStructurePost_node_x3.lgspFlags = candidate_checkStructurePost_node_x3.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x3;
                                    candidate_checkStructurePost_edge__edge1.lgspFlags = candidate_checkStructurePost_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge1;
                                    candidate_checkStructurePost_node_x1.lgspFlags = candidate_checkStructurePost_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x1;
                                    candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                                    candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
                                    return matches;
                                }
                            }
                            while( (candidate_checkStructurePost_edge__edge2 = candidate_checkStructurePost_edge__edge2.lgspInNext) != head_candidate_checkStructurePost_edge__edge2 );
                        }
                        candidate_checkStructurePost_node_x3.lgspFlags = candidate_checkStructurePost_node_x3.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x3;
                        candidate_checkStructurePost_edge__edge1.lgspFlags = candidate_checkStructurePost_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge1;
                    }
                    while( (candidate_checkStructurePost_edge__edge1 = candidate_checkStructurePost_edge__edge1.lgspInNext) != head_candidate_checkStructurePost_edge__edge1 );
                }
                candidate_checkStructurePost_node_x1.lgspFlags = candidate_checkStructurePost_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x1;
                candidate_checkStructurePost_node_x4.lgspFlags = candidate_checkStructurePost_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_node_x4;
                candidate_checkStructurePost_edge__edge0.lgspFlags = candidate_checkStructurePost_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_checkStructurePost_edge__edge0;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_checkStructurePost.IMatch_checkStructurePost match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches)
        {
            foreach(Rule_checkStructurePost.IMatch_checkStructurePost match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return false;
            foreach(Rule_checkStructurePost.IMatch_checkStructurePost match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            return true;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_checkStructurePost.IMatch_checkStructurePost)match);
            return ReturnArray;
        }
        public object[] ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_checkStructurePost.IMatch_checkStructurePost>)matches);
            return ReturnArray;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
    }

    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_replaceBadManager
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_replaceBadManager.IMatch_replaceBadManager match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns true if applied at least once. </summary>
        bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_replaceBadManager : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_replaceBadManager
    {
        public Action_replaceBadManager() {
            _rulePattern = Rule_replaceBadManager.Instance;
            patternGraph = _rulePattern.patternGraph;
            DynamicMatch = myMatch;
            ReturnArray = new object[0];
            matches = new GRGEN_LGSP.LGSPMatchesList<Rule_replaceBadManager.Match_replaceBadManager, Rule_replaceBadManager.IMatch_replaceBadManager>(this);
        }

        public Rule_replaceBadManager _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "replaceBadManager"; } }
        private GRGEN_LGSP.LGSPMatchesList<Rule_replaceBadManager.Match_replaceBadManager, Rule_replaceBadManager.IMatch_replaceBadManager> matches;

        public static Action_replaceBadManager Instance { get { return instance; } }
        private static Action_replaceBadManager instance = new Action_replaceBadManager();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            matches.Clear();
            int negLevel = 0;
            // Lookup replaceBadManager_edge__edge0 
            int type_id_candidate_replaceBadManager_edge__edge0 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_replaceBadManager_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_replaceBadManager_edge__edge0], candidate_replaceBadManager_edge__edge0 = head_candidate_replaceBadManager_edge__edge0.lgspTypeNext; candidate_replaceBadManager_edge__edge0 != head_candidate_replaceBadManager_edge__edge0; candidate_replaceBadManager_edge__edge0 = candidate_replaceBadManager_edge__edge0.lgspTypeNext)
            {
                uint prev__candidate_replaceBadManager_edge__edge0;
                prev__candidate_replaceBadManager_edge__edge0 = candidate_replaceBadManager_edge__edge0.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_replaceBadManager_edge__edge0.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Implicit Source replaceBadManager_node_x1 from replaceBadManager_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_replaceBadManager_node_x1 = candidate_replaceBadManager_edge__edge0.lgspSource;
                if(candidate_replaceBadManager_node_x1.lgspType.TypeID!=1) {
                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                    continue;
                }
                uint prev__candidate_replaceBadManager_node_x1;
                prev__candidate_replaceBadManager_node_x1 = candidate_replaceBadManager_node_x1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_replaceBadManager_node_x1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_replaceBadManager_node_x1).@id == 1))) {
                    candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                    continue;
                }
                // Implicit Target replaceBadManager_node_x4 from replaceBadManager_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_replaceBadManager_node_x4 = candidate_replaceBadManager_edge__edge0.lgspTarget;
                if(candidate_replaceBadManager_node_x4.lgspType.TypeID!=1) {
                    candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                    continue;
                }
                if((candidate_replaceBadManager_node_x4.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                {
                    candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                    continue;
                }
                uint prev__candidate_replaceBadManager_node_x4;
                prev__candidate_replaceBadManager_node_x4 = candidate_replaceBadManager_node_x4.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                candidate_replaceBadManager_node_x4.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                // Condition 
                if(!((((GRGEN_MODEL.IEmployee)candidate_replaceBadManager_node_x4).@id == 4))) {
                    candidate_replaceBadManager_node_x4.lgspFlags = candidate_replaceBadManager_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x4;
                    candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                    continue;
                }
                // Extend Incoming replaceBadManager_edge__edge1 from replaceBadManager_node_x4 
                GRGEN_LGSP.LGSPEdge head_candidate_replaceBadManager_edge__edge1 = candidate_replaceBadManager_node_x4.lgspInhead;
                if(head_candidate_replaceBadManager_edge__edge1 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_replaceBadManager_edge__edge1 = head_candidate_replaceBadManager_edge__edge1;
                    do
                    {
                        if(candidate_replaceBadManager_edge__edge1.lgspType.TypeID!=3) {
                            continue;
                        }
                        if((candidate_replaceBadManager_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            continue;
                        }
                        uint prev__candidate_replaceBadManager_edge__edge1;
                        prev__candidate_replaceBadManager_edge__edge1 = candidate_replaceBadManager_edge__edge1.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_replaceBadManager_edge__edge1.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Implicit Source replaceBadManager_node_x2 from replaceBadManager_edge__edge1 
                        GRGEN_LGSP.LGSPNode candidate_replaceBadManager_node_x2 = candidate_replaceBadManager_edge__edge1.lgspSource;
                        if(candidate_replaceBadManager_node_x2.lgspType.TypeID!=1) {
                            candidate_replaceBadManager_edge__edge1.lgspFlags = candidate_replaceBadManager_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge1;
                            continue;
                        }
                        if((candidate_replaceBadManager_node_x2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                        {
                            candidate_replaceBadManager_edge__edge1.lgspFlags = candidate_replaceBadManager_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge1;
                            continue;
                        }
                        uint prev__candidate_replaceBadManager_node_x2;
                        prev__candidate_replaceBadManager_node_x2 = candidate_replaceBadManager_node_x2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        candidate_replaceBadManager_node_x2.lgspFlags |= (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel;
                        // Condition 
                        if(!((((GRGEN_MODEL.IEmployee)candidate_replaceBadManager_node_x2).@id == 2))) {
                            candidate_replaceBadManager_node_x2.lgspFlags = candidate_replaceBadManager_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x2;
                            candidate_replaceBadManager_edge__edge1.lgspFlags = candidate_replaceBadManager_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge1;
                            continue;
                        }
                        // Extend Incoming replaceBadManager_edge__edge2 from replaceBadManager_node_x4 
                        GRGEN_LGSP.LGSPEdge head_candidate_replaceBadManager_edge__edge2 = candidate_replaceBadManager_node_x4.lgspInhead;
                        if(head_candidate_replaceBadManager_edge__edge2 != null)
                        {
                            GRGEN_LGSP.LGSPEdge candidate_replaceBadManager_edge__edge2 = head_candidate_replaceBadManager_edge__edge2;
                            do
                            {
                                if(candidate_replaceBadManager_edge__edge2.lgspType.TypeID!=3) {
                                    continue;
                                }
                                if((candidate_replaceBadManager_edge__edge2.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Implicit Source replaceBadManager_node_x3 from replaceBadManager_edge__edge2 
                                GRGEN_LGSP.LGSPNode candidate_replaceBadManager_node_x3 = candidate_replaceBadManager_edge__edge2.lgspSource;
                                if(candidate_replaceBadManager_node_x3.lgspType.TypeID!=1) {
                                    continue;
                                }
                                if((candidate_replaceBadManager_node_x3.lgspFlags & (uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) != 0)
                                {
                                    continue;
                                }
                                // Condition 
                                if(!((((GRGEN_MODEL.IEmployee)candidate_replaceBadManager_node_x3).@id == 3))) {
                                    continue;
                                }
                                Rule_replaceBadManager.Match_replaceBadManager match = matches.GetNextUnfilledPosition();
                                match._node_x1 = candidate_replaceBadManager_node_x1;
                                match._node_x4 = candidate_replaceBadManager_node_x4;
                                match._node_x2 = candidate_replaceBadManager_node_x2;
                                match._node_x3 = candidate_replaceBadManager_node_x3;
                                match._edge__edge0 = candidate_replaceBadManager_edge__edge0;
                                match._edge__edge1 = candidate_replaceBadManager_edge__edge1;
                                match._edge__edge2 = candidate_replaceBadManager_edge__edge2;
                                matches.PositionWasFilledFixIt();
                                // if enough matches were found, we leave
                                if(maxMatches > 0 && matches.Count >= maxMatches)
                                {
                                    candidate_replaceBadManager_node_x4.MoveInHeadAfter(candidate_replaceBadManager_edge__edge2);
                                    candidate_replaceBadManager_node_x4.MoveInHeadAfter(candidate_replaceBadManager_edge__edge1);
                                    graph.MoveHeadAfter(candidate_replaceBadManager_edge__edge0);
                                    candidate_replaceBadManager_node_x2.lgspFlags = candidate_replaceBadManager_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x2;
                                    candidate_replaceBadManager_edge__edge1.lgspFlags = candidate_replaceBadManager_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge1;
                                    candidate_replaceBadManager_node_x4.lgspFlags = candidate_replaceBadManager_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x4;
                                    candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                                    candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
                                    return matches;
                                }
                            }
                            while( (candidate_replaceBadManager_edge__edge2 = candidate_replaceBadManager_edge__edge2.lgspInNext) != head_candidate_replaceBadManager_edge__edge2 );
                        }
                        candidate_replaceBadManager_node_x2.lgspFlags = candidate_replaceBadManager_node_x2.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x2;
                        candidate_replaceBadManager_edge__edge1.lgspFlags = candidate_replaceBadManager_edge__edge1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge1;
                    }
                    while( (candidate_replaceBadManager_edge__edge1 = candidate_replaceBadManager_edge__edge1.lgspInNext) != head_candidate_replaceBadManager_edge__edge1 );
                }
                candidate_replaceBadManager_node_x4.lgspFlags = candidate_replaceBadManager_node_x4.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x4;
                candidate_replaceBadManager_node_x1.lgspFlags = candidate_replaceBadManager_node_x1.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_node_x1;
                candidate_replaceBadManager_edge__edge0.lgspFlags = candidate_replaceBadManager_edge__edge0.lgspFlags & ~((uint) GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << negLevel) | prev__candidate_replaceBadManager_edge__edge0;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_replaceBadManager.IMatch_replaceBadManager match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches)
        {
            foreach(Rule_replaceBadManager.IMatch_replaceBadManager match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public bool ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return false;
            foreach(Rule_replaceBadManager.IMatch_replaceBadManager match in matches) _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            return true;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_replaceBadManager.IMatch_replaceBadManager)match);
            return ReturnArray;
        }
        public object[] ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_replaceBadManager.IMatch_replaceBadManager>)matches);
            return ReturnArray;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(ApplyAll(maxMatches, actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
    }


    // class which instantiates and stores all the compiled actions of the module,
    // dynamic regeneration and compilation causes the old action to be overwritten by the new one
    // matching/rule patterns are analyzed at creation time here, once, so that later regeneration runs have all the information available
    public class ReplaceManagerActions : GRGEN_LGSP.LGSPActions
    {
        public ReplaceManagerActions(GRGEN_LGSP.LGSPGraph lgspgraph, string modelAsmName, string actionsAsmName)
            : base(lgspgraph, modelAsmName, actionsAsmName)
        {
            InitActions();
        }

        public ReplaceManagerActions(GRGEN_LGSP.LGSPGraph lgspgraph)
            : base(lgspgraph)
        {
            InitActions();
        }

        private void InitActions()
        {
            GRGEN_LGSP.PatternGraphAnalyzer analyzer = new GRGEN_LGSP.PatternGraphAnalyzer();
            analyzer.AnalyzeNestingOfAndRemember(Rule_checkStructurePre.Instance);
            actions.Add("checkStructurePre", (GRGEN_LGSP.LGSPAction) Action_checkStructurePre.Instance);
            @checkStructurePre = Action_checkStructurePre.Instance;
            analyzer.AnalyzeNestingOfAndRemember(Rule_checkStructurePost.Instance);
            actions.Add("checkStructurePost", (GRGEN_LGSP.LGSPAction) Action_checkStructurePost.Instance);
            @checkStructurePost = Action_checkStructurePost.Instance;
            analyzer.AnalyzeNestingOfAndRemember(Rule_replaceBadManager.Instance);
            actions.Add("replaceBadManager", (GRGEN_LGSP.LGSPAction) Action_replaceBadManager.Instance);
            @replaceBadManager = Action_replaceBadManager.Instance;
            analyzer.ComputeInterPatternRelations();
            analyzer.AnalyzeWithInterPatternRelationsKnown(Rule_checkStructurePre.Instance);
            analyzer.AnalyzeWithInterPatternRelationsKnown(Rule_checkStructurePost.Instance);
            analyzer.AnalyzeWithInterPatternRelationsKnown(Rule_replaceBadManager.Instance);
        }
        
        public IAction_checkStructurePre @checkStructurePre;
        public IAction_checkStructurePost @checkStructurePost;
        public IAction_replaceBadManager @replaceBadManager;
        
        
        public override string Name { get { return "ReplaceManagerActions"; } }
        public override string ModelMD5Hash { get { return "9aefa44ec5665e21cb1f9e737bbb0960"; } }
    }
}