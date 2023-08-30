using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTOOP
{
    internal class SinhVien
    {
        //Thuộc tính (Get và Set)
        private int mssv;
        private string hoten;
        private double diemlt;
        private double diemth;
        
        public int MSSV
        {
            get { return mssv; }
            set { 
                //Ép dữ liệu
                // if (value <= 0)
                // {
                //     mssv = 1;
                // }

                //Kiểm tra dữ liệu
                if (value <= 0)
                {
                    throw new Exception("MSSV phải lớn hơn 0");
                }
                mssv = value;
            }
        }
        
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (value.Equals("") || value.Equals(null) || value.Length == 0)
                {
                    throw new Exception("Họ tên không được để trống");
                }
                hoten = value;
            }
        }
        
        public double DiemLT
        {
            get { return diemlt; }
            set
            {
                //Ép dữ liệu
                // if (value > 10)
                //     diemlt = 10;
                // else if (value < 0)
                //     diemlt = 0;

                //Kiểm tra dữ liệu
                if (value < 0.0 || value > 10.0)
                {
                    throw new Exception("Điểm không hợp lệ");
                }
                diemlt = value;
            }
        }
        
        public double DiemTH
        {
            get { return diemth; }
            set
            {
                //Ép dữ liệu
                // if(value > 10)
                //     diemth = 10;
                // else if (value < 0)
                //     diemth = 0;

                //Kiểm tra dữ liệu
                if (value < 0.0 || value > 10.0)
                {
                    throw new Exception("Điểm không hợp lệ");
                }
                diemth = value;
            }
        }

        //Constructor
        ///Constructor không tham số
        public SinhVien()
        {
            mssv = 0;
            hoten = "Vô Danh";
            diemlt = 0.0;
            diemth = 0.0;
        }

        ///Constructor có tham số
        public SinhVien(int mssv, string hoten,  double diemlt,  double diemth)
        {
            MSSV = mssv;
            Hoten = hoten;
            DiemLT = diemlt;
            DiemTH = diemth;
        }

        //Phương thức
        public double DTB()
        {
            return ( diemlt + diemth ) / 2;
        }

        public string XuatChuoi()
        {
            return mssv + "\t\t " + hoten + "\t\t " + diemlt + "\t\t" + diemth + "\t\t " + DTB();
        }
    }
}
