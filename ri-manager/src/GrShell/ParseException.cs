/* Generated By:CSharpCC: Do not edit this line. ParseException.cs Version 3.2 */
namespace de.unika.ipd.grGen.grShell {


/// <summary>
/// This exception is thrown when parse errors are encountered.
/// </summary>
/// <remarks>
/// You can explicitly create objects of this exception type by
/// calling the method GenerateParseException in the generated
/// parser.
/// <para>
/// You can modify this class to customize your error reporting
/// mechanisms so long as you retain the public fields.
/// </para>
/// </remarks>
public class ParseException : System.Exception {

  /**
   * This constructor is used by the method "GenerateParseException"
   * in the generated parser. Calling this constructor generates
   * a new object of this type with the fields "currentToken",
   * "expectedTokenSequences", and "tokenImage" set.  The boolean
   * flag "specialConstructor" is also set to true to indicate that
   * this constructor was used to create this object.
   * This constructor calls its super class with the empty string
   * to force the "toString" method of parent class "Throwable" to
   * print the error message in the form:
   *     ParseException: <result of getMessage>
   */
  public ParseException(Token currentTokenVal,
                        int[][] expectedTokenSequencesVal,
                        string[] tokenImageVal
                       ) : base("") {
    specialConstructor = true;
    currentToken = currentTokenVal;
    expectedTokenSequences = expectedTokenSequencesVal;
    tokenImage = tokenImageVal;
  }

  /**
   * The following constructors are for use by you for whatever
   * purpose you can think of.  Constructing the exception in this
   * manner makes the exception behave in the normal way - i.e., as
   * documented in the class "Throwable".  The fields "errorToken",
   * "expectedTokenSequences", and "tokenImage" do not contain
   * relevant information.  The JavaCC generated code does not use
   * these constructors.
   */

  public ParseException() :
    base() {
    specialConstructor = false;
  }

  public ParseException(string message) :
    base(message) {
    specialConstructor = false;
  }

  /**
   * This variable determines which constructor was used to create
   * this object and thereby affects the semantics of the
   * "getMessage" method (see below).
   */
  protected bool specialConstructor;

  /**
   * This is the last token that has been consumed successfully.  If
   * this object has been created due to a parse error, the token
   * followng this token will (therefore) be the first error token.
   */
  public Token currentToken;

  /**
   * Each entry in this array is an array of integers.  Each array
   * of integers represents a sequence of tokens (by their ordinal
   * values) that is expected at this point of the parse.
   */
  public int[][] expectedTokenSequences;

  /**
   * This is a reference to the "tokenImage" array of the generated
   * parser within which the parse error occurred.  This array is
   * defined in the generated ...Constants interface.
   */
  public string[] tokenImage;

  /**
   * This method has the standard behavior when this object has been
   * created using the standard constructors.  Otherwise, it uses
   * "currentToken" and "expectedTokenSequences" to generate a parse
   * error message and returns it.  If this object has been created
   * due to a parse error, and you do not catch it (it gets thrown
   * from the parser), then this method is called during the printing
   * of the final stack trace, and hence the correct error message
   * gets displayed.
   */
  public override string Message {
    get {
      if (!specialConstructor) {
        return base.Message;
      }
      string expected = "";
      int maxSize = 0;
      for (int i = 0; i < expectedTokenSequences.Length; i++) {
        if (maxSize < expectedTokenSequences[i].Length) {
          maxSize = expectedTokenSequences[i].Length;
        }
        for (int j = 0; j < expectedTokenSequences[i].Length; j++) {
          expected += tokenImage[expectedTokenSequences[i][j]] + " ";
        }
        if (expectedTokenSequences[i][expectedTokenSequences[i].Length - 1] != 0) {
          expected += "...";
        }
        expected += eol + "    ";
      }
      string retval = "Encountered \"";
      Token tok = currentToken.next;
      for (int i = 0; i < maxSize; i++) {
        if (i != 0) retval += " ";
        if (tok.kind == 0) {
          retval += tokenImage[0];
          break;
        }
        retval += AddEscapes(tok.image);
        tok = tok.next; 
      }
      if (currentToken.next.kind == 0) {
        retval += "\" after line ";
      } else {
        retval += "\" at line ";
      }
      retval += currentToken.next.beginLine + ", column " + currentToken.next.beginColumn;
      retval += "." + eol;
      if (expectedTokenSequences.Length == 1) {
        retval += "Was expecting:" + eol + "    ";
      } else {
        retval += "Was expecting one of:" + eol + "    ";
      }
      retval += expected;
      return retval;
    }
  }

  /**
   * The end of line string for this machine.
   */
  protected string eol = System.Environment.NewLine;
 
  /**
   * Used to convert raw characters to their escaped version
   * when these raw version cannot be used as part of an ASCII
   * string literal.
   */
  protected string AddEscapes(string str) {
      System.Text.StringBuilder retval = new System.Text.StringBuilder();
      char ch;
      for (int i = 0; i < str.Length; i++) {
        switch (str[i]) {
           case '\0' :
              continue;
           case '\b':
              retval.Append("\\b");
              continue;
           case '\t':
              retval.Append("\\t");
              continue;
           case '\n':
              retval.Append("\\n");
              continue;
           case '\f':
              retval.Append("\\f");
              continue;
           case '\r':
              retval.Append("\\r");
              continue;
           case '\"':
              retval.Append("\\\"");
              continue;
           case '\'':
              retval.Append("\\\'");
              continue;
           case '\\':
              retval.Append("\\\\");
              continue;
           default:
              if ((ch = str[i]) < 0x20 || ch > 0x7e) {
                 string s = "0000" + System.Convert.ToString((int)ch, 16);
                 retval.Append("\\u" + s.Substring(s.Length - 4, s.Length - (s.Length - 4)));
              } else {
                 retval.Append(ch);
              }
              continue;
        }
      }
      return retval.ToString();
   }

}
}
