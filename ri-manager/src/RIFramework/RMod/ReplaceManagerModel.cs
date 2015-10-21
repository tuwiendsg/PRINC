// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "ReplaceManager.grg" on Tue Apr 03 14:59:56 CEST 2012

using System;
using System.Collections.Generic;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;

namespace de.unika.ipd.grGen.Model_ReplaceManager
{
	using GRGEN_MODEL = de.unika.ipd.grGen.Model_ReplaceManager;
	//
	// Enums
	//

	public class Enums
	{
	}

	//
	// Node types
	//

	public enum NodeTypes { @Node, @Employee };

	// *** Node Node ***


	public sealed class @Node : GRGEN_LGSP.LGSPNode, GRGEN_LIBGR.INode
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Node[] pool = new GRGEN_MODEL.@Node[10];
		
		static @Node() {
		}
		
		public @Node() : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
			// implicit initialization, map/set/array creation of Node
		}

		public static GRGEN_MODEL.NodeType_Node TypeInstance { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Node(this); }

		private @Node(GRGEN_MODEL.@Node oldElem) : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
		}

		public override bool AreAttributesEqual(GRGEN_LIBGR.IGraphElement that) {
			if(!(that is @Node)) return false;
			@Node that_ = (@Node)that;
			return true
			;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set/array creation of Node
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set/array creation of Node
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set/array creation of Node
		}
	}

	public sealed class NodeType_Node : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Node typeVar = new GRGEN_MODEL.NodeType_Node();
		public static bool[] isA = new bool[] { true, false, };
		public static bool[] isMyType = new bool[] { true, true, };
		public NodeType_Node() : base((int) NodeTypes.@Node)
		{
		}
		public override string Name { get { return "Node"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.libGr.INode"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.@Node"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Node();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Node();
		}

	}

	// *** Node Employee ***

	public interface IEmployee : GRGEN_LIBGR.INode
	{
		int @id { get; set; }
		int @marked { get; set; }
	}

	public sealed class @Employee : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IEmployee
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Employee[] pool = new GRGEN_MODEL.@Employee[10];
		
		// explicit initializations of Employee for target Employee
		// implicit initializations of Employee for target Employee
		static @Employee() {
		}
		
		public @Employee() : base(GRGEN_MODEL.NodeType_Employee.typeVar)
		{
			// implicit initialization, map/set/array creation of Employee
			// explicit initializations of Employee for target Employee
		}

		public static GRGEN_MODEL.NodeType_Employee TypeInstance { get { return GRGEN_MODEL.NodeType_Employee.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Employee(this); }

		private @Employee(GRGEN_MODEL.@Employee oldElem) : base(GRGEN_MODEL.NodeType_Employee.typeVar)
		{
			id_M0no_suXx_h4rD = oldElem.id_M0no_suXx_h4rD;
			marked_M0no_suXx_h4rD = oldElem.marked_M0no_suXx_h4rD;
		}

		public override bool AreAttributesEqual(GRGEN_LIBGR.IGraphElement that) {
			if(!(that is @Employee)) return false;
			@Employee that_ = (@Employee)that;
			return true
				&& id_M0no_suXx_h4rD == that_.id_M0no_suXx_h4rD
				&& marked_M0no_suXx_h4rD == that_.marked_M0no_suXx_h4rD
			;
		}

		public static GRGEN_MODEL.@Employee CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Employee node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Employee();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set/array creation of Employee
				node.@id = 0;
				node.@marked = 0;
				// explicit initializations of Employee for target Employee
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Employee CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Employee node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Employee();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set/array creation of Employee
				node.@id = 0;
				node.@marked = 0;
				// explicit initializations of Employee for target Employee
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private int id_M0no_suXx_h4rD;
		public int @id
		{
			get { return id_M0no_suXx_h4rD; }
			set { id_M0no_suXx_h4rD = value; }
		}

		private int marked_M0no_suXx_h4rD;
		public int @marked
		{
			get { return marked_M0no_suXx_h4rD; }
			set { marked_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "id": return this.@id;
				case "marked": return this.@marked;
			}
			throw new NullReferenceException(
				"The node type \"Employee\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "id": this.@id = (int) value; return;
				case "marked": this.@marked = (int) value; return;
			}
			throw new NullReferenceException(
				"The node type \"Employee\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set/array creation of Employee
			this.@id = 0;
			this.@marked = 0;
			// explicit initializations of Employee for target Employee
		}
	}

	public sealed class NodeType_Employee : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Employee typeVar = new GRGEN_MODEL.NodeType_Employee();
		public static bool[] isA = new bool[] { true, true, };
		public static bool[] isMyType = new bool[] { false, true, };
		public static GRGEN_LIBGR.AttributeType AttributeType_id;
		public static GRGEN_LIBGR.AttributeType AttributeType_marked;
		public NodeType_Employee() : base((int) NodeTypes.@Employee)
		{
			AttributeType_id = new GRGEN_LIBGR.AttributeType("id", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
			AttributeType_marked = new GRGEN_LIBGR.AttributeType("marked", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
		}
		public override string Name { get { return "Employee"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.IEmployee"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.@Employee"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Employee();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_id;
				yield return AttributeType_marked;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "id" : return AttributeType_id;
				case "marked" : return AttributeType_marked;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Employee newNode = new GRGEN_MODEL.@Employee();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Employee:
					// copy attributes for: Employee
					{
						GRGEN_MODEL.IEmployee old = (GRGEN_MODEL.IEmployee) oldNode;
						newNode.@id = old.@id;
						newNode.@marked = old.@marked;
					}
					break;
			}
			return newNode;
		}

	}

	//
	// Node model
	//

	public sealed class ReplaceManagerNodeModel : GRGEN_LIBGR.INodeModel
	{
		public ReplaceManagerNodeModel()
		{
			GRGEN_MODEL.NodeType_Node.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_Employee.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Employee.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Employee.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Employee.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Employee.typeVar,
			};
			GRGEN_MODEL.NodeType_Employee.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Employee.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Employee.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Employee.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Employee.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Employee.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Employee.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
		}
		public bool IsNodeModel { get { return true; } }
		public GRGEN_LIBGR.NodeType RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		public GRGEN_LIBGR.NodeType GetType(string name)
		{
			switch(name)
			{
				case "Node" : return GRGEN_MODEL.NodeType_Node.typeVar;
				case "Employee" : return GRGEN_MODEL.NodeType_Employee.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.NodeType[] types = {
			GRGEN_MODEL.NodeType_Node.typeVar,
			GRGEN_MODEL.NodeType_Employee.typeVar,
		};
		public GRGEN_LIBGR.NodeType[] Types { get { return types; } }
		GRGEN_LIBGR.GrGenType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.NodeType_Node),
			typeof(GRGEN_MODEL.NodeType_Employee),
		};
		public System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.NodeType_Employee.AttributeType_id,
			GRGEN_MODEL.NodeType_Employee.AttributeType_marked,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Edge types
	//

	public enum EdgeTypes { @AEdge, @Edge, @UEdge, @ManagedBy };

	// *** Edge AEdge ***


	public sealed class EdgeType_AEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_AEdge typeVar = new GRGEN_MODEL.EdgeType_AEdge();
		public static bool[] isA = new bool[] { true, false, false, false, };
		public static bool[] isMyType = new bool[] { true, true, true, true, };
		public EdgeType_AEdge() : base((int) EdgeTypes.@AEdge)
		{
		}
		public override string Name { get { return "AEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Arbitrary; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type AEdge!");
		}
	}

	// *** Edge Edge ***


	public sealed class @Edge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IEdge
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Edge[] pool = new GRGEN_MODEL.@Edge[10];
		
		static @Edge() {
		}
		
		public @Edge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, source, target)
		{
			// implicit initialization, map/set/array creation of Edge
		}

		public static GRGEN_MODEL.EdgeType_Edge TypeInstance { get { return GRGEN_MODEL.EdgeType_Edge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Edge(GRGEN_MODEL.@Edge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, newSource, newTarget)
		{
		}

		public override bool AreAttributesEqual(GRGEN_LIBGR.IGraphElement that) {
			if(!(that is @Edge)) return false;
			@Edge that_ = (@Edge)that;
			return true
			;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of Edge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of Edge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set/array creation of Edge
		}
	}

	public sealed class EdgeType_Edge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Edge typeVar = new GRGEN_MODEL.EdgeType_Edge();
		public static bool[] isA = new bool[] { true, true, false, false, };
		public static bool[] isMyType = new bool[] { false, true, false, true, };
		public EdgeType_Edge() : base((int) EdgeTypes.@Edge)
		{
		}
		public override string Name { get { return "Edge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.@Edge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge UEdge ***


	public sealed class @UEdge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IEdge
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@UEdge[] pool = new GRGEN_MODEL.@UEdge[10];
		
		static @UEdge() {
		}
		
		public @UEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, source, target)
		{
			// implicit initialization, map/set/array creation of UEdge
		}

		public static GRGEN_MODEL.EdgeType_UEdge TypeInstance { get { return GRGEN_MODEL.EdgeType_UEdge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @UEdge(GRGEN_MODEL.@UEdge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, newSource, newTarget)
		{
		}

		public override bool AreAttributesEqual(GRGEN_LIBGR.IGraphElement that) {
			if(!(that is @UEdge)) return false;
			@UEdge that_ = (@UEdge)that;
			return true
			;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of UEdge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of UEdge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set/array creation of UEdge
		}
	}

	public sealed class EdgeType_UEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_UEdge typeVar = new GRGEN_MODEL.EdgeType_UEdge();
		public static bool[] isA = new bool[] { true, false, true, false, };
		public static bool[] isMyType = new bool[] { false, false, true, false, };
		public EdgeType_UEdge() : base((int) EdgeTypes.@UEdge)
		{
		}
		public override string Name { get { return "UEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.@UEdge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Undirected; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge ManagedBy ***

	public interface IManagedBy : GRGEN_LIBGR.IEdge
	{
		int @id { get; set; }
		int @marked { get; set; }
	}

	public sealed class @ManagedBy : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IManagedBy
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@ManagedBy[] pool = new GRGEN_MODEL.@ManagedBy[10];
		
		// explicit initializations of ManagedBy for target ManagedBy
		// implicit initializations of ManagedBy for target ManagedBy
		static @ManagedBy() {
		}
		
		public @ManagedBy(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_ManagedBy.typeVar, source, target)
		{
			// implicit initialization, map/set/array creation of ManagedBy
			// explicit initializations of ManagedBy for target ManagedBy
		}

		public static GRGEN_MODEL.EdgeType_ManagedBy TypeInstance { get { return GRGEN_MODEL.EdgeType_ManagedBy.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@ManagedBy(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @ManagedBy(GRGEN_MODEL.@ManagedBy oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_ManagedBy.typeVar, newSource, newTarget)
		{
			id_M0no_suXx_h4rD = oldElem.id_M0no_suXx_h4rD;
			marked_M0no_suXx_h4rD = oldElem.marked_M0no_suXx_h4rD;
		}

		public override bool AreAttributesEqual(GRGEN_LIBGR.IGraphElement that) {
			if(!(that is @ManagedBy)) return false;
			@ManagedBy that_ = (@ManagedBy)that;
			return true
				&& id_M0no_suXx_h4rD == that_.id_M0no_suXx_h4rD
				&& marked_M0no_suXx_h4rD == that_.marked_M0no_suXx_h4rD
			;
		}

		public static GRGEN_MODEL.@ManagedBy CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@ManagedBy edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@ManagedBy(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of ManagedBy
				edge.@id = 0;
				edge.@marked = 0;
				// explicit initializations of ManagedBy for target ManagedBy
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@ManagedBy CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@ManagedBy edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@ManagedBy(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set/array creation of ManagedBy
				edge.@id = 0;
				edge.@marked = 0;
				// explicit initializations of ManagedBy for target ManagedBy
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private int id_M0no_suXx_h4rD;
		public int @id
		{
			get { return id_M0no_suXx_h4rD; }
			set { id_M0no_suXx_h4rD = value; }
		}

		private int marked_M0no_suXx_h4rD;
		public int @marked
		{
			get { return marked_M0no_suXx_h4rD; }
			set { marked_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "id": return this.@id;
				case "marked": return this.@marked;
			}
			throw new NullReferenceException(
				"The edge type \"ManagedBy\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "id": this.@id = (int) value; return;
				case "marked": this.@marked = (int) value; return;
			}
			throw new NullReferenceException(
				"The edge type \"ManagedBy\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set/array creation of ManagedBy
			this.@id = 0;
			this.@marked = 0;
			// explicit initializations of ManagedBy for target ManagedBy
		}
	}

	public sealed class EdgeType_ManagedBy : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_ManagedBy typeVar = new GRGEN_MODEL.EdgeType_ManagedBy();
		public static bool[] isA = new bool[] { true, true, false, true, };
		public static bool[] isMyType = new bool[] { false, false, false, true, };
		public static GRGEN_LIBGR.AttributeType AttributeType_id;
		public static GRGEN_LIBGR.AttributeType AttributeType_marked;
		public EdgeType_ManagedBy() : base((int) EdgeTypes.@ManagedBy)
		{
			AttributeType_id = new GRGEN_LIBGR.AttributeType("id", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
			AttributeType_marked = new GRGEN_LIBGR.AttributeType("marked", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
		}
		public override string Name { get { return "ManagedBy"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.IManagedBy"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_ReplaceManager.@ManagedBy"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@ManagedBy((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_id;
				yield return AttributeType_marked;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "id" : return AttributeType_id;
				case "marked" : return AttributeType_marked;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			GRGEN_LGSP.LGSPEdge oldEdge = (GRGEN_LGSP.LGSPEdge) oldIEdge;
			GRGEN_MODEL.@ManagedBy newEdge = new GRGEN_MODEL.@ManagedBy((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
			switch(oldEdge.Type.TypeID)
			{
				case (int) EdgeTypes.@ManagedBy:
					// copy attributes for: ManagedBy
					{
						GRGEN_MODEL.IManagedBy old = (GRGEN_MODEL.IManagedBy) oldEdge;
						newEdge.@id = old.@id;
						newEdge.@marked = old.@marked;
					}
					break;
			}
			return newEdge;
		}

	}

	//
	// Edge model
	//

	public sealed class ReplaceManagerEdgeModel : GRGEN_LIBGR.IEdgeModel
	{
		public ReplaceManagerEdgeModel()
		{
			GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_ManagedBy.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_ManagedBy.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
			};
			GRGEN_MODEL.EdgeType_ManagedBy.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_ManagedBy.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_ManagedBy.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_ManagedBy.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_ManagedBy.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_ManagedBy.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
		}
		public bool IsNodeModel { get { return false; } }
		public GRGEN_LIBGR.EdgeType RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		public GRGEN_LIBGR.EdgeType GetType(string name)
		{
			switch(name)
			{
				case "AEdge" : return GRGEN_MODEL.EdgeType_AEdge.typeVar;
				case "Edge" : return GRGEN_MODEL.EdgeType_Edge.typeVar;
				case "UEdge" : return GRGEN_MODEL.EdgeType_UEdge.typeVar;
				case "ManagedBy" : return GRGEN_MODEL.EdgeType_ManagedBy.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.EdgeType[] types = {
			GRGEN_MODEL.EdgeType_AEdge.typeVar,
			GRGEN_MODEL.EdgeType_Edge.typeVar,
			GRGEN_MODEL.EdgeType_UEdge.typeVar,
			GRGEN_MODEL.EdgeType_ManagedBy.typeVar,
		};
		public GRGEN_LIBGR.EdgeType[] Types { get { return types; } }
		GRGEN_LIBGR.GrGenType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.EdgeType_AEdge),
			typeof(GRGEN_MODEL.EdgeType_Edge),
			typeof(GRGEN_MODEL.EdgeType_UEdge),
			typeof(GRGEN_MODEL.EdgeType_ManagedBy),
		};
		public System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.EdgeType_ManagedBy.AttributeType_id,
			GRGEN_MODEL.EdgeType_ManagedBy.AttributeType_marked,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// IGraphModel implementation
	//
	public sealed class ReplaceManagerGraphModel : GRGEN_LIBGR.IGraphModel
	{
		private ReplaceManagerNodeModel nodeModel = new ReplaceManagerNodeModel();
		private ReplaceManagerEdgeModel edgeModel = new ReplaceManagerEdgeModel();
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
		};

		public string ModelName { get { return "ReplaceManager"; } }
		public GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public string MD5Hash { get { return "3f94f978808f24ed4d99fb95930dc5a4"; } }
	}

	//
	// IGraph/IGraphModel implementation
	//
	public class ReplaceManagerGraph : GRGEN_LGSP.LGSPGraph, GRGEN_LIBGR.IGraphModel
	{
		public ReplaceManagerGraph() : base(GetNextGraphName())
		{
			InitializeGraph(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Employee CreateNodeEmployee()
		{
			return GRGEN_MODEL.@Employee.CreateNode(this);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@ManagedBy CreateEdgeManagedBy(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@ManagedBy.CreateEdge(this, source, target);
		}

		private ReplaceManagerNodeModel nodeModel = new ReplaceManagerNodeModel();
		private ReplaceManagerEdgeModel edgeModel = new ReplaceManagerEdgeModel();
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
		};

		public string ModelName { get { return "ReplaceManager"; } }
		public GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public string MD5Hash { get { return "3f94f978808f24ed4d99fb95930dc5a4"; } }
	}

	//
	// INamedGraph/IGraphModel implementation
	//
	public class ReplaceManagerNamedGraph : GRGEN_LGSP.LGSPNamedGraph, GRGEN_LIBGR.IGraphModel
	{
		public ReplaceManagerNamedGraph() : base(GetNextGraphName())
		{
			InitializeGraph(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode(string nodeName)
		{
			return GRGEN_MODEL.@Node.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Employee CreateNodeEmployee()
		{
			return GRGEN_MODEL.@Employee.CreateNode(this);
		}

		public GRGEN_MODEL.@Employee CreateNodeEmployee(string nodeName)
		{
			return GRGEN_MODEL.@Employee.CreateNode(this, nodeName);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@ManagedBy CreateEdgeManagedBy(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@ManagedBy.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@ManagedBy CreateEdgeManagedBy(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@ManagedBy.CreateEdge(this, source, target, edgeName);
		}

		private ReplaceManagerNodeModel nodeModel = new ReplaceManagerNodeModel();
		private ReplaceManagerEdgeModel edgeModel = new ReplaceManagerEdgeModel();
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
		};

		public string ModelName { get { return "ReplaceManager"; } }
		public GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public string MD5Hash { get { return "3f94f978808f24ed4d99fb95930dc5a4"; } }
	}
}
