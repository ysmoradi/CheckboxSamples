using Xamarin.Forms;

namespace Bit.View
{
    public class FrameProps
    {
        public static BindableProperty BorderWidthProperty = BindableProperty.CreateAttached("BorderWidth", typeof(double), typeof(Frame), defaultValue: -1d);

        public static double GetBorderWidth(BindableObject view)
        {
            return (double)view.GetValue(BorderWidthProperty);
        }

        public static void SetBorderWidth(BindableObject view, double value)
        {
            view.SetValue(BorderWidthProperty, value);
        }
    }
}
