using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
namespace ConnectionMoMo
{
	public class LogicMoMo
	{
        Connection db = new Connection();
        public void ThanhToan(string MAHD, PictureBox pic_qrcode)
		{
            string sotien = db.ExcuteReader($"EXEC Tong_ThanhTien '{MAHD}'", "Thành tiền");
            foreach(DataRow item in db.loadDB("SELECT * FROM THONGTINCUAHANG").Rows)
			{
                var qrcode_text = $"2|99|{item["SDT"].ToString().Trim()}|{item["HOTEN"].ToString().Trim()}|{item["EMAIL"]}|0|0|{sotien}";
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                //Bitmap logo = resizeImage(Properties.Resources.Logo_MoMo_Circle, 32, 32) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                //g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                pic_qrcode.Image = bitmap;

            }

        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
    }
}
