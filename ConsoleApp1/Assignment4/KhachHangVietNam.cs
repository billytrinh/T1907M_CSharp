namespace ConsoleApp1.Assignment4
{
    public class KhachHangVietNam:KhachHang
    {
        private string doituong;

        public KhachHangVietNam(int id, string name, string billDate, int number, string doituong) : base(id, name, billDate, number)
        {
            this.doituong = doituong;
        }

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }
    }
}