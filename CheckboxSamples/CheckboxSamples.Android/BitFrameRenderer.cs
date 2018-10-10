using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using Bit.View;
using CheckboxSamples.Droid;
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Frame), typeof(BitFrameRenderer))]

namespace CheckboxSamples.Droid
{
    public class BitFrameRenderer : Xamarin.Forms.Platform.Android.FastRenderers.FrameRenderer
    {
        public BitFrameRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                double borderWidth = FrameProps.GetBorderWidth(e.NewElement);
                Color borderColor = e.NewElement.BorderColor;

                if (borderWidth != (double)FrameProps.BorderWidthProperty.DefaultValue && borderColor.IsDefault == false)
                {
                    GradientDrawable _backgroundDrawable = (GradientDrawable)typeof(Xamarin.Forms.Platform.Android.FastRenderers.FrameRenderer)
                        .GetField(nameof(_backgroundDrawable), BindingFlags.Instance | BindingFlags.NonPublic)
                        .GetValue(this);

                    DisplayMetrics displayMetrics = Context.Resources.DisplayMetrics;

                    int borderWidthInPixel = (int)Math.Round(borderWidth * (displayMetrics.Xdpi / (int)DisplayMetricsDensity.Default));

                    _backgroundDrawable.SetStroke(borderWidthInPixel, borderColor.ToAndroid());
                }
            }
        }
    }
}
