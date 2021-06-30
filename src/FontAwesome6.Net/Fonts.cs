using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FontAwesome6
{
    /// <summary>
    /// Provides FontFamilies and Typefaces of FontAwesome6.
    /// </summary>
    public static class Fonts
    {
        /// <summary>
        /// FontAwesome6 Regular FontFamily
        /// </summary>
        public static readonly FontFamily RegularFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome6.Net;component/"), "./Fonts/#Font Awesome 6 Pro-Regular-400");
        /// <summary>
        /// FontAwesome6 Solid FontFamily
        /// </summary>
        public static readonly FontFamily SolidFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome6.Net;component/"), "./Fonts/#Font Awesome 6 Pro-Solid-900");
        /// <summary>
        /// FontAwesome6 Brands FontFamily
        /// </summary>
        public static readonly FontFamily LightFontFamily = new FontFamily(new Uri("pack://application:,,,/FontAwesome6.Net;component/"), "./Fonts/#Font Awesome 6 Pro-Light-300");
        /// <summary>
        /// FontAwesome6 Regular Typeface
        /// </summary>
        public static readonly Typeface RegularTypeface = new Typeface(RegularFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        /// <summary>
        /// FontAwesome6 Solid Typeface
        /// </summary>
        public static readonly Typeface SolidTypeface = new Typeface(SolidFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
        /// <summary>
        /// FontAwesome6 Brands Typeface
        /// </summary>
        public static readonly Typeface LightTypeface = new Typeface(LightFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);        
    }
}
