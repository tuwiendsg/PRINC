/* Generated By:CSharpCC: Do not edit this line. GRSImporterTokenManager.cs */
namespace de.unika.ipd.grGen.libGr.porter {

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using de.unika.ipd.grGen.libGr;

public class GRSImporterTokenManager : GRSImporterConstants {
  public  System.IO.TextWriter debugStream = Console.Out;
  public  void SetDebugStream(System.IO.TextWriter ds) { debugStream = ds; }
private int mccStopStringLiteralDfa_0(int pos, long active0)
{
   switch (pos)
   {
      case 0:
         if ((active0 & 8573157488L) != 0L)
         {
            mccmatchedKind = 46;
            return 7;
         }
         if ((active0 & 512L) != 0L)
            return 61;
         if ((active0 & 72057594037927936L) != 0L)
            return 62;
         if ((active0 & 256L) != 0L)
            return 63;
         if ((active0 & 4L) != 0L)
            return 7;
         if ((active0 & 24576L) != 0L)
            return 25;
         return -1;
      case 1:
         if ((active0 & 8573157376L) != 0L)
         {
            if (mccmatchedPos != 1) {
               mccmatchedKind = 46;
               mccmatchedPos = 1;
            }
            return 7;
         }
         return -1;
      case 2:
         if ((active0 & 5284823040L) != 0L)
         {
            mccmatchedKind = 46;
            mccmatchedPos = 2;
            return 7;
         }
         if ((active0 & 3288334336L) != 0L)
            return 7;
         return -1;
      case 3:
         if ((active0 & 4345298944L) != 0L)
         {
            mccmatchedKind = 46;
            mccmatchedPos = 3;
            return 7;
         }
         if ((active0 & 939524096L) != 0L)
            return 7;
         return -1;
      default :
         return -1;
   }
}
private int mccStartNfa_0(int pos, long active0)
{
   return mccMoveNfa_0(mccStopStringLiteralDfa_0(pos, active0), pos + 1);
}
private int mccStopAtPos(int pos, int kind)
{
   mccmatchedKind = kind;
   mccmatchedPos = pos;
   return pos + 1;
}
private int mccStartNfaWithStates_0(int pos, int kind, int state) {
   mccmatchedKind = kind;
   mccmatchedPos = pos;
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) { return pos + 1; }
   return mccMoveNfa_0(state, pos + 1);
}
private int mccMoveStringLiteralDfa0_0()
{
   switch((int)curChar) {
      case 9:
         return mccStartNfaWithStates_0(0, 2, 7);
      case 10:
         return mccStopAtPos(0, 7);
      case 34:
         return mccStartNfaWithStates_0(0, 8, 63);
      case 36:
         return mccStopAtPos(0, 58);
      case 39:
         return mccStartNfaWithStates_0(0, 9, 61);
      case 40:
         return mccStopAtPos(0, 15);
      case 41:
         return mccStopAtPos(0, 16);
      case 44:
         return mccStopAtPos(0, 12);
      case 45:
         mccmatchedKind = 14;
         return mccMoveStringLiteralDfa1_0(8192L);
      case 46:
         return mccStartNfaWithStates_0(0, 56, 62);
      case 58:
         mccmatchedKind = 57;
         return mccMoveStringLiteralDfa1_0(1024L);
      case 60:
         return mccStopAtPos(0, 18);
      case 61:
         return mccStopAtPos(0, 11);
      case 62:
         return mccStopAtPos(0, 19);
      case 64:
         return mccStopAtPos(0, 17);
      case 91:
         return mccStopAtPos(0, 22);
      case 92:
         return mccMoveStringLiteralDfa1_0(112L);
      case 93:
         return mccStopAtPos(0, 23);
      case 97:
         return mccMoveStringLiteralDfa1_0(4294967296L);
      case 102:
         return mccMoveStringLiteralDfa1_0(16777216L);
      case 103:
         return mccMoveStringLiteralDfa1_0(33554432L);
      case 109:
         return mccMoveStringLiteralDfa1_0(2147483648L);
      case 110:
         return mccMoveStringLiteralDfa1_0(469762048L);
      case 115:
         return mccMoveStringLiteralDfa1_0(1073741824L);
      case 116:
         return mccMoveStringLiteralDfa1_0(536870912L);
      case 123:
         return mccStopAtPos(0, 20);
      case 125:
         return mccStopAtPos(0, 21);
      default :
         return mccMoveNfa_0(0, 0);
   }
}
private int mccMoveStringLiteralDfa1_0(long active0)
{
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) {
      mccStopStringLiteralDfa_0(0, active0);
      return 1;
   }
   switch((int)curChar) {
      case 10:
         if ((active0 & 32L) != 0L)
            return mccStopAtPos(1, 5);
         break;
      case 13:
         if ((active0 & 64L) != 0L)
         {
            mccmatchedKind = 6;
            mccmatchedPos = 1;
         }
         return mccMoveStringLiteralDfa2_0(active0, 16L);
      case 58:
         if ((active0 & 1024L) != 0L)
            return mccStopAtPos(1, 10);
         break;
      case 62:
         if ((active0 & 8192L) != 0L)
            return mccStopAtPos(1, 13);
         break;
      case 97:
         return mccMoveStringLiteralDfa2_0(active0, 2164260864L);
      case 101:
         return mccMoveStringLiteralDfa2_0(active0, 1140850688L);
      case 111:
         return mccMoveStringLiteralDfa2_0(active0, 134217728L);
      case 114:
         return mccMoveStringLiteralDfa2_0(active0, 4865392640L);
      case 117:
         return mccMoveStringLiteralDfa2_0(active0, 268435456L);
      default :
         break;
   }
   return mccStartNfa_0(0, active0);
}
private int mccMoveStringLiteralDfa2_0(long old0, long active0)
{
   if (((active0 &= old0)) == 0L)
      return mccStartNfa_0(0, old0); 
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) {
      mccStopStringLiteralDfa_0(1, active0);
      return 2;
   }
   switch((int)curChar) {
      case 10:
         if ((active0 & 16L) != 0L)
            return mccStopAtPos(2, 4);
         break;
      case 97:
         return mccMoveStringLiteralDfa3_0(active0, 33554432L);
      case 100:
         return mccMoveStringLiteralDfa3_0(active0, 134217728L);
      case 108:
         return mccMoveStringLiteralDfa3_0(active0, 285212672L);
      case 112:
         if ((active0 & 2147483648L) != 0L)
            return mccStartNfaWithStates_0(2, 31, 7);
         break;
      case 114:
         return mccMoveStringLiteralDfa3_0(active0, 4294967296L);
      case 116:
         if ((active0 & 1073741824L) != 0L)
            return mccStartNfaWithStates_0(2, 30, 7);
         break;
      case 117:
         return mccMoveStringLiteralDfa3_0(active0, 536870912L);
      case 119:
         if ((active0 & 67108864L) != 0L)
            return mccStartNfaWithStates_0(2, 26, 7);
         break;
      default :
         break;
   }
   return mccStartNfa_0(1, active0);
}
private int mccMoveStringLiteralDfa3_0(long old0, long active0)
{
   if (((active0 &= old0)) == 0L)
      return mccStartNfa_0(1, old0); 
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) {
      mccStopStringLiteralDfa_0(2, active0);
      return 3;
   }
   switch((int)curChar) {
      case 97:
         return mccMoveStringLiteralDfa4_0(active0, 4294967296L);
      case 101:
         if ((active0 & 134217728L) != 0L)
            return mccStartNfaWithStates_0(3, 27, 7);
         else if ((active0 & 536870912L) != 0L)
            return mccStartNfaWithStates_0(3, 29, 7);
         break;
      case 108:
         if ((active0 & 268435456L) != 0L)
            return mccStartNfaWithStates_0(3, 28, 7);
         break;
      case 112:
         return mccMoveStringLiteralDfa4_0(active0, 33554432L);
      case 115:
         return mccMoveStringLiteralDfa4_0(active0, 16777216L);
      default :
         break;
   }
   return mccStartNfa_0(2, active0);
}
private int mccMoveStringLiteralDfa4_0(long old0, long active0)
{
   if (((active0 &= old0)) == 0L)
      return mccStartNfa_0(2, old0); 
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) {
      mccStopStringLiteralDfa_0(3, active0);
      return 4;
   }
   switch((int)curChar) {
      case 101:
         if ((active0 & 16777216L) != 0L)
            return mccStartNfaWithStates_0(4, 24, 7);
         break;
      case 104:
         if ((active0 & 33554432L) != 0L)
            return mccStartNfaWithStates_0(4, 25, 7);
         break;
      case 121:
         if ((active0 & 4294967296L) != 0L)
            return mccStartNfaWithStates_0(4, 32, 7);
         break;
      default :
         break;
   }
   return mccStartNfa_0(3, active0);
}
private void mccCheckNAdd(int state)
{
   if (mccrounds[state] != mccround)
   {
      mccstateSet[mccnewStateCnt++] = state;
      mccrounds[state] = mccround;
   }
}
private void mccAddStates(int start, int end)
{
   do {
      mccstateSet[mccnewStateCnt++] = mccnextStates[start];
   } while (start++ != end);
}
private void mccCheckNAddTwoStates(int state1, int state2)
{
   mccCheckNAdd(state1);
   mccCheckNAdd(state2);
}
private void mccCheckNAddStates(int start, int end)
{
   do {
      mccCheckNAdd(mccnextStates[start]);
   } while (start++ != end);
}
private void mccCheckNAddStates(int start)
{
   mccCheckNAdd(mccnextStates[start]);
   mccCheckNAdd(mccnextStates[start + 1]);
}
static readonly long[] mccbitVec0 = {
   0L, 0L, -1L, -1L
};
private int mccMoveNfa_0(int startState, int curPos)
{
   int[] nextStates;
   int startsAt = 0;
   mccnewStateCnt = 61;
   int i = 1;
   mccstateSet[0] = startState;
   int j, kind = Int32.MaxValue;
   for (;;)
   {
      if (++mccround == Int32.MaxValue)
         ReInitRounds();
      if (curChar < 64)
      {
         long l = 1L << curChar;
         do
         {
            switch(mccstateSet[--i])
            {
               case 61:
                  if ((-549755823105 & l) != 0L)
                     mccCheckNAddTwoStates(4, 5);
                  else if (curChar == 39)
                  {
                     if (kind > 45)
                        kind = 45;
                  }
                  break;
               case 62:
                  if ((287948901175001088 & l) != 0L)
                  {
                     if (kind > 42)
                        kind = 42;
                     mccCheckNAddStates(0, 2);
                  }
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddStates(3, 5);
                  break;
               case 0:
                  if ((140741783313407 & l) != 0L)
                  {
                     if (kind > 46)
                        kind = 46;
                     mccCheckNAdd(7);
                  }
                  else if ((287948901175001088 & l) != 0L)
                  {
                     if (kind > 33)
                        kind = 33;
                     mccCheckNAddStates(6, 22);
                  }
                  else if (curChar == 46)
                     mccCheckNAddTwoStates(26, 38);
                  else if (curChar == 45)
                     mccCheckNAddStates(23, 32);
                  else if (curChar == 35)
                  {
                     if (kind > 47)
                        kind = 47;
                     mccCheckNAdd(9);
                  }
                  else if (curChar == 39)
                     mccCheckNAddTwoStates(4, 5);
                  else if (curChar == 34)
                     mccCheckNAddTwoStates(1, 2);
                  if (curChar == 48)
                     mccAddStates(33, 36);
                  break;
               case 25:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(46, 36);
                  else if (curChar == 46)
                     mccCheckNAdd(38);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(42, 43);
                  else if (curChar == 46)
                     mccCheckNAdd(26);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(30, 31);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddStates(37, 40);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(16, 17);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(14, 15);
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(12, 13);
                  if ((287948901175001088 & l) != 0L)
                  {
                     if (kind > 33)
                        kind = 33;
                     mccCheckNAdd(11);
                  }
                  break;
               case 63:
                  if ((-17179878401 & l) != 0L)
                     mccCheckNAddTwoStates(1, 2);
                  else if (curChar == 34)
                  {
                     if (kind > 44)
                        kind = 44;
                  }
                  break;
               case 1:
                  if ((-17179878401 & l) != 0L)
                     mccCheckNAddTwoStates(1, 2);
                  break;
               case 2:
                  if (curChar == 34 && kind > 44)
                     kind = 44;
                  break;
               case 3:
                  if (curChar == 39)
                     mccCheckNAddTwoStates(4, 5);
                  break;
               case 4:
                  if ((-549755823105 & l) != 0L)
                     mccCheckNAddTwoStates(4, 5);
                  break;
               case 5:
                  if (curChar == 39 && kind > 45)
                     kind = 45;
                  break;
               case 6:
                  if ((140741783313407 & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  mccCheckNAdd(7);
                  break;
               case 7:
                  if ((288089642958314495 & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  mccCheckNAdd(7);
                  break;
               case 8:
                  if (curChar != 35)
                     break;
                  if (kind > 47)
                     kind = 47;
                  mccCheckNAdd(9);
                  break;
               case 9:
                  if ((-1025 & l) == 0L)
                     break;
                  if (kind > 47)
                     kind = 47;
                  mccCheckNAdd(9);
                  break;
               case 10:
                  if (curChar == 45)
                     mccCheckNAddStates(23, 32);
                  break;
               case 11:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 33)
                     kind = 33;
                  mccCheckNAdd(11);
                  break;
               case 12:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(12, 13);
                  break;
               case 14:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(14, 15);
                  break;
               case 16:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(16, 17);
                  break;
               case 18:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddStates(37, 40);
                  break;
               case 19:
                  if (curChar == 46)
                     mccCheckNAdd(20);
                  break;
               case 20:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddStates(41, 43);
                  break;
               case 22:
                  if ((43980465111040 & l) != 0L)
                     mccCheckNAdd(23);
                  break;
               case 23:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(23, 24);
                  break;
               case 26:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddStates(3, 5);
                  break;
               case 28:
                  if ((43980465111040 & l) != 0L)
                     mccCheckNAdd(29);
                  break;
               case 29:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(29, 24);
                  break;
               case 30:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(30, 31);
                  break;
               case 31:
                  if (curChar == 46)
                     mccCheckNAdd(32);
                  break;
               case 32:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 42)
                     kind = 42;
                  mccCheckNAddStates(44, 46);
                  break;
               case 34:
                  if ((43980465111040 & l) != 0L)
                     mccCheckNAdd(35);
                  break;
               case 35:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 42)
                     kind = 42;
                  mccCheckNAddTwoStates(35, 36);
                  break;
               case 37:
                  if (curChar == 46)
                     mccCheckNAdd(38);
                  break;
               case 38:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 42)
                     kind = 42;
                  mccCheckNAddStates(0, 2);
                  break;
               case 40:
                  if ((43980465111040 & l) != 0L)
                     mccCheckNAdd(41);
                  break;
               case 41:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 42)
                     kind = 42;
                  mccCheckNAddTwoStates(41, 36);
                  break;
               case 42:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(42, 43);
                  break;
               case 44:
                  if ((43980465111040 & l) != 0L)
                     mccCheckNAdd(45);
                  break;
               case 45:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 42)
                     kind = 42;
                  mccCheckNAddTwoStates(45, 36);
                  break;
               case 46:
                  if ((287948901175001088 & l) != 0L)
                     mccCheckNAddTwoStates(46, 36);
                  break;
               case 47:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 33)
                     kind = 33;
                  mccCheckNAddStates(6, 22);
                  break;
               case 48:
                  if (curChar == 48)
                     mccAddStates(33, 36);
                  break;
               case 50:
                  if ((287948901175001088 & l) == 0L)
                     break;
                  if (kind > 37)
                     kind = 37;
                  mccstateSet[mccnewStateCnt++] = 50;
                  break;
               case 52:
                  if ((287948901175001088 & l) != 0L)
                     mccAddStates(47, 48);
                  break;
               case 55:
                  if ((287948901175001088 & l) != 0L)
                     mccAddStates(49, 50);
                  break;
               case 58:
                  if ((287948901175001088 & l) != 0L)
                     mccAddStates(51, 52);
                  break;
               case 60:
                  if (curChar == 46)
                     mccCheckNAddTwoStates(26, 38);
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else if (curChar < 128)
      {
         long l = 1L << (curChar & 63);
         do
         {
            switch(mccstateSet[--i])
            {
               case 61:
               case 4:
                  mccCheckNAddTwoStates(4, 5);
                  break;
               case 0:
               case 7:
                  if ((-4035225266795053058 & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  mccCheckNAdd(7);
                  break;
               case 63:
               case 1:
                  mccCheckNAddTwoStates(1, 2);
                  break;
               case 9:
                  if (kind > 47)
                     kind = 47;
                  mccstateSet[mccnewStateCnt++] = 9;
                  break;
               case 13:
                  if ((144115188109410304 & l) != 0L && kind > 34)
                     kind = 34;
                  break;
               case 15:
                  if ((2251799814209536 & l) != 0L && kind > 35)
                     kind = 35;
                  break;
               case 17:
                  if ((17592186048512 & l) != 0L && kind > 36)
                     kind = 36;
                  break;
               case 21:
                  if ((137438953504 & l) != 0L)
                     mccAddStates(53, 54);
                  break;
               case 24:
                  if ((274877907008 & l) != 0L && kind > 41)
                     kind = 41;
                  break;
               case 27:
                  if ((137438953504 & l) != 0L)
                     mccAddStates(55, 56);
                  break;
               case 33:
                  if ((137438953504 & l) != 0L)
                     mccAddStates(57, 58);
                  break;
               case 36:
                  if ((68719476752 & l) != 0L && kind > 42)
                     kind = 42;
                  break;
               case 39:
                  if ((137438953504 & l) != 0L)
                     mccAddStates(59, 60);
                  break;
               case 43:
                  if ((137438953504 & l) != 0L)
                     mccAddStates(61, 62);
                  break;
               case 49:
                  if (curChar == 120)
                     mccCheckNAdd(50);
                  break;
               case 50:
                  if ((541165879422 & l) == 0L)
                     break;
                  if (kind > 37)
                     kind = 37;
                  mccCheckNAdd(50);
                  break;
               case 51:
                  if (curChar == 120)
                     mccCheckNAdd(52);
                  break;
               case 52:
                  if ((541165879422 & l) != 0L)
                     mccCheckNAddTwoStates(52, 53);
                  break;
               case 53:
                  if ((144115188109410304 & l) != 0L && kind > 38)
                     kind = 38;
                  break;
               case 54:
                  if (curChar == 120)
                     mccCheckNAdd(55);
                  break;
               case 55:
                  if ((541165879422 & l) != 0L)
                     mccCheckNAddTwoStates(55, 56);
                  break;
               case 56:
                  if ((2251799814209536 & l) != 0L && kind > 39)
                     kind = 39;
                  break;
               case 57:
                  if (curChar == 120)
                     mccCheckNAdd(58);
                  break;
               case 58:
                  if ((541165879422 & l) != 0L)
                     mccCheckNAddTwoStates(58, 59);
                  break;
               case 59:
                  if ((17592186048512 & l) != 0L && kind > 40)
                     kind = 40;
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else
      {
         int i2 = (curChar & 0xff) >> 6;
         long l2 = 1L << (curChar & 63);
         do
         {
            switch(mccstateSet[--i])
            {
               case 61:
               case 4:
                  if ((mccbitVec0[i2] & l2) != 0L)
                     mccCheckNAddTwoStates(4, 5);
                  break;
               case 0:
               case 7:
                  if ((mccbitVec0[i2] & l2) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  mccCheckNAdd(7);
                  break;
               case 63:
               case 1:
                  if ((mccbitVec0[i2] & l2) != 0L)
                     mccCheckNAddTwoStates(1, 2);
                  break;
               case 9:
                  if ((mccbitVec0[i2] & l2) == 0L)
                     break;
                  if (kind > 47)
                     kind = 47;
                  mccstateSet[mccnewStateCnt++] = 9;
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      if (kind != Int32.MaxValue)
      {
         mccmatchedKind = kind;
         mccmatchedPos = curPos;
         kind = Int32.MaxValue;
      }
      ++curPos;
      if ((i = mccnewStateCnt) == (startsAt = 61 - (mccnewStateCnt = startsAt)))
         return curPos;
      try { curChar = input_stream.ReadChar(); }
      catch(System.IO.IOException) { return curPos; }
   }
}
private int mccStopStringLiteralDfa_1(int pos, long active0)
{
   switch (pos)
   {
      default :
         return -1;
   }
}
private int mccStartNfa_1(int pos, long active0)
{
   return mccMoveNfa_1(mccStopStringLiteralDfa_1(pos, active0), pos + 1);
}
private int mccStartNfaWithStates_1(int pos, int kind, int state) {
   mccmatchedKind = kind;
   mccmatchedPos = pos;
   try { curChar = input_stream.ReadChar(); }
   catch(System.IO.IOException) { return pos + 1; }
   return mccMoveNfa_1(state, pos + 1);
}
private int mccMoveStringLiteralDfa0_1()
{
   switch((int)curChar) {
      case 9:
         return mccStartNfaWithStates_1(0, 49, 6);
      case 10:
         return mccStopAtPos(0, 54);
      default :
         return mccMoveNfa_1(0, 0);
   }
}
private int mccMoveNfa_1(int startState, int curPos)
{
   int[] nextStates;
   int startsAt = 0;
   mccnewStateCnt = 7;
   int i = 1;
   mccstateSet[0] = startState;
   int j, kind = Int32.MaxValue;
   for (;;)
   {
      if (++mccround == Int32.MaxValue)
         ReInitRounds();
      if (curChar < 64)
      {
         long l = 1L << curChar;
         do
         {
            switch(mccstateSet[--i])
            {
               case 0:
                  if ((6341063237341010943 & l) != 0L)
                  {
                     if (kind > 53)
                        kind = 53;
                     mccCheckNAdd(6);
                  }
                  else if (curChar == 39)
                     mccCheckNAddTwoStates(4, 5);
                  else if (curChar == 34)
                     mccCheckNAddTwoStates(1, 2);
                  break;
               case 1:
                  if ((-17179878401 & l) != 0L)
                     mccCheckNAddTwoStates(1, 2);
                  break;
               case 2:
                  if (curChar == 34 && kind > 51)
                     kind = 51;
                  break;
               case 3:
                  if (curChar == 39)
                     mccCheckNAddTwoStates(4, 5);
                  break;
               case 4:
                  if ((-549755823105 & l) != 0L)
                     mccCheckNAddTwoStates(4, 5);
                  break;
               case 5:
                  if (curChar == 39 && kind > 52)
                     kind = 52;
                  break;
               case 6:
                  if ((6341063237341010943 & l) == 0L)
                     break;
                  if (kind > 53)
                     kind = 53;
                  mccCheckNAdd(6);
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else if (curChar < 128)
      {
         long l = 1L << (curChar & 63);
         do
         {
            switch(mccstateSet[--i])
            {
               case 0:
               case 6:
                  if ((-1152921504606846977 & l) == 0L)
                     break;
                  if (kind > 53)
                     kind = 53;
                  mccCheckNAdd(6);
                  break;
               case 1:
                  mccAddStates(63, 64);
                  break;
               case 4:
                  mccAddStates(65, 66);
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else
      {
         int i2 = (curChar & 0xff) >> 6;
         long l2 = 1L << (curChar & 63);
         do
         {
            switch(mccstateSet[--i])
            {
               case 0:
               case 6:
                  if ((mccbitVec0[i2] & l2) == 0L)
                     break;
                  if (kind > 53)
                     kind = 53;
                  mccCheckNAdd(6);
                  break;
               case 1:
                  if ((mccbitVec0[i2] & l2) != 0L)
                     mccAddStates(63, 64);
                  break;
               case 4:
                  if ((mccbitVec0[i2] & l2) != 0L)
                     mccAddStates(65, 66);
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      if (kind != Int32.MaxValue)
      {
         mccmatchedKind = kind;
         mccmatchedPos = curPos;
         kind = Int32.MaxValue;
      }
      ++curPos;
      if ((i = mccnewStateCnt) == (startsAt = 7 - (mccnewStateCnt = startsAt)))
         return curPos;
      try { curChar = input_stream.ReadChar(); }
      catch(System.IO.IOException) { return curPos; }
   }
}
static readonly int[] mccnextStates = {
   38, 39, 36, 26, 27, 24, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 
   24, 30, 31, 42, 43, 46, 36, 11, 12, 14, 16, 18, 25, 30, 37, 42, 
   46, 49, 51, 54, 57, 18, 19, 21, 24, 20, 21, 24, 32, 33, 36, 52, 
   53, 55, 56, 58, 59, 22, 23, 28, 29, 34, 35, 40, 41, 44, 45, 1, 
   2, 4, 5, 
};
public static readonly string[] mccstrLiteralImages = {
"", null, null, null, null, null, null, "\n", "\"", "\'", "::", "=", ",", 
"->", "-", "(", ")", "@", "<", ">", "{", "}", "[", "]", "false", "graph", "new", 
"node", "null", "true", "set", "map", "array", null, null, null, null, null, null, 
null, null, null, null, null, null, null, null, null, null, null, null, null, null, 
null, "\n", null, ".", ":", "$", };
public static readonly string[] lexStateNames = {
   "DEFAULT", 
   "WithinFilename", 
};
public static readonly int[] mccnewLexState = {
   -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
   -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
   -1, 0, 0, 0, 0, 0, -1, -1, -1, 
};
static readonly long[] mcctoToken = {
   574340893885071233, 
};
static readonly long[] mcctoSkip = {
   2111062325330046, 
};
static readonly long[] mcctoSpecial = {
   140737488355328, 
};
protected SimpleCharStream input_stream;
private readonly int[] mccrounds = new int[61];
private readonly int[] mccstateSet = new int[122];
System.Text.StringBuilder image;
int mccimageLen;
int lengthOfMatch;
protected char curChar;
public GRSImporterTokenManager(SimpleCharStream stream) {
   if (SimpleCharStream.staticFlag)
      throw new System.SystemException("ERROR: Cannot use a static CharStream class with a non-static lexical analyzer.");
   input_stream = stream;
}
public GRSImporterTokenManager(SimpleCharStream stream, int lexState) :
   this(stream) {
   SwitchTo(lexState);
}
public void ReInit(SimpleCharStream stream) {
   mccmatchedPos = mccnewStateCnt = 0;
   curLexState = defaultLexState;
   input_stream = stream;
   ReInitRounds();
}
private void ReInitRounds()
{
   int i;
   mccround = -2147483647;
   for (i = 61; i-- > 0;)
      mccrounds[i] = Int32.MinValue;
}
public void ReInit(SimpleCharStream stream, int lexState) {
   ReInit(stream);
   SwitchTo(lexState);
}
public void SwitchTo(int lexState) {
   if (lexState >= 2 || lexState < 0)
      throw new TokenMgrError("Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.", TokenMgrError.InvalidLexicalState);
   else
      curLexState = lexState;
}

protected Token mccFillToken()
{
   Token t = Token.NewToken(mccmatchedKind);
   t.kind = mccmatchedKind;
   string im = mccstrLiteralImages[mccmatchedKind];
   t.image = (im == null) ? input_stream.GetImage() : im;
   t.beginLine = input_stream.BeginLine;
   t.beginColumn = input_stream.BeginColumn;
   t.endLine = input_stream.EndLine;
   t.endColumn = input_stream.EndColumn;
   return t;
}

int curLexState = 0;
int defaultLexState = 0;
int mccnewStateCnt;
int mccround;
int mccmatchedPos;
int mccmatchedKind;

public Token GetNextToken() {
  int kind;
  Token specialToken = null;
  Token matchedToken;
  int curPos = 0;

for (;;) {
   try {
      curChar = input_stream.BeginToken();
   } catch(System.IO.IOException) {
      mccmatchedKind = 0;
      matchedToken = mccFillToken();
      matchedToken.specialToken = specialToken;
      return matchedToken;
   }
   image = null;
   mccimageLen = 0;

   switch(curLexState) {
     case 0:
       try { input_stream.Backup(0);
          while (curChar <= ' ' && (4294975488L & (1L << curChar)) != 0L)
             curChar = input_stream.BeginToken();
       } catch (System.IO.IOException) { goto EOFLoop; }
       mccmatchedKind = Int32.MaxValue;
       mccmatchedPos = 0;
       curPos = mccMoveStringLiteralDfa0_0();
       break;
     case 1:
       try { input_stream.Backup(0);
          while (curChar <= ' ' && (4294975488L & (1L << curChar)) != 0L)
             curChar = input_stream.BeginToken();
       } catch (System.IO.IOException) { goto EOFLoop; }
       mccmatchedKind = Int32.MaxValue;
       mccmatchedPos = 0;
       curPos = mccMoveStringLiteralDfa0_1();
       if (mccmatchedPos == 0 && mccmatchedKind > 55)
       {
          mccmatchedKind = 55;
       }
       break;
   }
     if (mccmatchedKind != Int32.MaxValue) {
        if (mccmatchedPos + 1 < curPos)
           input_stream.Backup(curPos - mccmatchedPos - 1);
        if ((mcctoToken[mccmatchedKind >> 6] & (1L << (mccmatchedKind & 63))) != 0L) {
           matchedToken = mccFillToken();
           matchedToken.specialToken = specialToken;
           TokenLexicalActions(matchedToken);
       if (mccnewLexState[mccmatchedKind] != -1)
         curLexState = mccnewLexState[mccmatchedKind];
           return matchedToken;
        }
        else
        {
           if ((mcctoSpecial[mccmatchedKind >> 6] & (1L << (mccmatchedKind & 63))) != 0L) {
              matchedToken = mccFillToken();
              if (specialToken == null)
                 specialToken = matchedToken;
              else {
                 matchedToken.specialToken = specialToken;
                 specialToken = (specialToken.next = matchedToken);
              }
           }
         if (mccnewLexState[mccmatchedKind] != -1)
           curLexState = mccnewLexState[mccmatchedKind];
           goto EOFLoop;
        }
     }
     int error_line = input_stream.EndLine;
     int error_column = input_stream.EndColumn;
     string error_after = null;
     bool EOFSeen = false;
     try { input_stream.ReadChar(); input_stream.Backup(1); }
     catch (System.IO.IOException) {
        EOFSeen = true;
        error_after = curPos <= 1 ? "" : input_stream.GetImage();
        if (curChar == '\n' || curChar == '\r') {
           error_line++;
           error_column = 0;
        } else
           error_column++;
     }
     if (!EOFSeen) {
        input_stream.Backup(1);
        error_after = curPos <= 1 ? "" : input_stream.GetImage();
     }
     throw new TokenMgrError(EOFSeen, curLexState, error_line, error_column, error_after, curChar, TokenMgrError.LexicalError);
EOFLoop: ;
  }
}

void TokenLexicalActions(Token matchedToken)
{
   switch(mccmatchedKind) {
      case 44 :
        if (image == null)
            image = new System.Text.StringBuilder(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
         else
            image.Append(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
                  matchedToken.image = matchedToken.image.Substring(1, matchedToken.image.Length-2);
         break;
      case 45 :
        if (image == null)
            image = new System.Text.StringBuilder(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
         else
            image.Append(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
                  matchedToken.image = matchedToken.image.Substring(1, matchedToken.image.Length-2);
         break;
      case 51 :
        if (image == null)
            image = new System.Text.StringBuilder(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
         else
            image.Append(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
                  matchedToken.image = matchedToken.image.Substring(1, matchedToken.image.Length-2);
         break;
      case 52 :
        if (image == null)
            image = new System.Text.StringBuilder(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
         else
            image.Append(new String(input_stream.GetSuffix(mccimageLen + (lengthOfMatch = mccmatchedPos + 1))));
                  matchedToken.image = matchedToken.image.Substring(1, matchedToken.image.Length-2);
         break;
      default : 
         break;
   }
}
}
}
