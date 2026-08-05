using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace RFIDBasedAttendanceMonitoringSystem.Shared
{
    public static class PhotoHelper
    {
        public static Bitmap Load(string relativePhotoPath)
        {
            if (string.IsNullOrWhiteSpace(relativePhotoPath))
                return null;

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePhotoPath);

            if (!File.Exists(fullPath))
                return null;

            try
            {
                byte[] imageBytes = File.ReadAllBytes(fullPath);
                using (var ms = new MemoryStream(imageBytes))
                using (var loadedImage = Image.FromStream(ms))
                {
                    return new Bitmap(loadedImage);
                }
            }
            catch
            {
                return null;
            }
        }

        public static string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "?";
            var parts = fullName.Replace(",", "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "?";
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0].Substring(0, 1) + parts[1].Substring(0, 1)).ToUpper();
        }

        public static Bitmap CreateInitialsAvatar(string fullName, int size, Color? backColor = null, Color? foreColor = null)
        {
            Color bg = backColor ?? Color.FromArgb(230, 244, 240);
            Color fg = foreColor ?? Color.FromArgb(0, 184, 148);

            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            using (Brush bgBrush = new SolidBrush(bg))
            using (Brush fgBrush = new SolidBrush(fg))
            using (Font font = new Font("Calibri", size * 0.36f, FontStyle.Bold))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                g.FillEllipse(bgBrush, 0, 0, size, size);

                string initials = GetInitials(fullName);
                SizeF textSize = g.MeasureString(initials, font);
                PointF textLocation = new PointF(
                    (size - textSize.Width) / 2f,
                    (size - textSize.Height) / 2f);

                g.DrawString(initials, font, fgBrush, textLocation);
            }

            return bmp;
        }
    }
}