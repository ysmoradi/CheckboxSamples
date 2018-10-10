using Bit.View;
using CheckboxSamples.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Frame), typeof(BitFrameRenderer))]

namespace CheckboxSamples.UWP
{
    public class BitFrameRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                double borderWidth = FrameProps.GetBorderWidth(e.NewElement);

                if (borderWidth != (double)FrameProps.BorderWidthProperty.DefaultValue)
                {
                    Control.BorderThickness = new Windows.UI.Xaml.Thickness(borderWidth);
                }
            }
        }
    }
}
