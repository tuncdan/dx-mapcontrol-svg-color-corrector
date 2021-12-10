using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SvgColorCorrector
{
    internal class ConversionUtils
    {
        internal static string RgbToHex(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Equals("none"))
                return "none";

            if (value.StartsWith("#") || !value.Contains(','))
                return value;

            var data = value.Split('(', ')');
            var numbers = data[1].Split(',');

            string result = "#";

            foreach (var number in numbers)
                result += Convert.ToInt32(number).ToString("X2");

            return result;
        }

        internal static IEnumerable<int> FixSvgColorElements(XDocument rawFile)
        {
            var descendants = rawFile.DescendantNodes().Where(ss => ss is XElement).ToList();
            descendants.Where(ss => ((XElement)ss).Name.LocalName.ToLower().Equals("clippath")).Remove();

            int total = descendants.Count;
            int count = 0;

            foreach (XElement element in descendants)
            {
                yield return (++count * 100) / total;

                element.Attributes().Where(attr => attr.Name.LocalName.ToLower().Equals("clip-path") || attr.Name.LocalName.ToLower().Equals("clippath")).Remove();

                var fill = element.Attributes("fill");
                foreach (var fl in fill)
                    fl.SetValue(RgbToHex(fl.Value));

                var stroke = element.Attributes("stroke");
                foreach (var st in stroke)
                    st.SetValue(RgbToHex(st.Value));

                if (element.Parent != null && element.Parent.Name.LocalName.Equals("g") && element.Parent.Attributes().Count() > 0)
                    foreach (var attr in element.Parent.Attributes())
                        element.SetAttributeValue(attr.Name, attr.Value);
            };

            foreach (var element in descendants.Where(ss => ((XElement)ss).Name.LocalName.Equals("g")))
                ((XElement)element).Attributes().Remove();

            yield return 100;
        }
    }
}
