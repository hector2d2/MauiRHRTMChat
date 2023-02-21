using System;
namespace RHRTMChat.Drawables
{
	public class CustomAppBar: IDrawable
	{
		public CustomAppBar()
		{
		}

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
			canvas.FillColor = Colors.Blue;
			//canvas.
        }
    }
}

