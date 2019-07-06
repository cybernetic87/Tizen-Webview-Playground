using System;
using Tizen;

namespace GAssist
{
    internal class HtmlResponseParser
    {
        public static string ParseHtmlResponse(string html)
        {
            //var bodyOld = "body{background:transparent;margin:0}";
            //var bodyNew =
            //    "body { background: transparent; margin: 0; -webkit - transform: scale(0.5); }";
            var shadow = "<div class=\"popout-shadow\" id=\"assistant-shadow\"></div>";
            var positionAbs = "position: absolute;";

            var htmlOld = "html";
            var htmlNew = "html {\n\tposition: relative;\n    max-width: 400px;\n    max-height: 400px;\n\t\n    height: 100%;\n\t}";

            var popoutOld = "#popout{";
            var popoutNew = "#popout{ -moz-transform: scale(0.4, 0.4); zoom: 0.4; zoom: 40%;";

            return html.Replace(htmlOld, htmlNew).Replace(popoutOld, popoutNew).Replace(shadow, "").Replace(positionAbs, "");
        }

        public static string ParseHtmlResponse2(string html)
        {
            var flex = "display: -webkit-flex";
            var wrap =
                "display: -webkit-flex;\nheight: 360;\nwidth: 360;\n-webkit-flex-wrap: wrap;\n-webkit-flex-shrink: 1;";

            var parsed = html.Replace(flex, wrap);
            Log.Debug("HTMLPARSER", parsed);
            return parsed;
        }
    }
}