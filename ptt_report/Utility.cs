using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Office.Interop.Word;

namespace ptt_report
{
    public static class Utility
    {
        public static void FindAndReplaceText(ref Selection sel, string txtFind, string txtReplace)
        {
            string strReplace = txtReplace.Trim().Replace("\r\n", "\v");
            int strLen = strReplace.Length;
            int max = 200;
            int i;
            int strPoint;
            string strChunk;

            if (strLen > max)
            {
                i = 0;
                while (strLen > (i * max))
                {
                    strPoint = i * max;
                    if ((strLen - strPoint) >= max)
                    {
                        strChunk = strReplace.Substring(strPoint, max);
                        sel.Find.Text = txtFind;
                        sel.Find.Replacement.Text = strChunk + txtFind;
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        i++;
                    }
                    else
                    {
                        strChunk = strReplace.Substring(strPoint, (strLen - strPoint));
                        sel.Find.Text = txtFind;
                        sel.Find.Replacement.Text = strChunk;
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        i++;
                    }
                }
            }
            else
            {
                sel.Find.Text = txtFind;
                sel.Find.Replacement.Text = strReplace;
                sel.Find.Wrap = WdFindWrap.wdFindContinue;
                sel.Find.Forward = true;
                sel.Find.Format = false;
                sel.Find.MatchCase = false;
                sel.Find.MatchWholeWord = false;
                sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
            }
        }
    }
}