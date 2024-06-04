using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Lab3.Theater
{
    public class Class
    {
        //Login Form
        public class Admin
        {
            private string username;
            public int permit; 
            public Admin()
            {
                username = string.Empty;
                permit = -1;
            }
            public Admin(string u, int p)
            {
                this.username = u;
                this.permit = p; //0:Modder 1:Staff
            }
        }
        public class Movie
        {
            public string name, origin, id;
            public long price;
            public List<int> arrRoom;
            public string info;
            public Movie()
            {
                name = origin = id = string.Empty;
                price = 0;
                arrRoom = new List<int>();
            }
            public Movie(string id, string name, string origin, long price, List<int> arrRoom)
            {
                this.id = id;
                this.name = name;
                this.origin = origin;
                this.price = price;
                this.arrRoom = arrRoom;
            }
            public string setInfo()
            {
                return string.Format("Tên gốc: {0}\r\nGiá vé chuẩn: {1}.000đ\r\nPhòng chiếu: {2}", this.origin, this.price.ToString(), string.Join(", ", this.arrRoom));
            }
        }
        //Bill Form
        public class Price
        {
            Movie movie;
            public long normal, vip, sweet;
            public Price()
            {
                movie = new Movie();
                normal = vip = sweet = 0;
            }
            public Price(Movie m)
            {
                this.movie = m;
                this.normal = m.price;
                this.vip = m.price + 10;
                this.sweet = m.price * 2 + 30;
            }
        }
        //Seat Form
        public class Theater
        {
            public int normal, vip, sweet, col;
            public string name, id;
            public Theater()
            {
                normal = vip = sweet = col = 0;
                name = id = string.Empty;
            }
            public Theater(string id, string name, int nor, int vip, int sw)
            {
                this.id = id;
                this.normal = nor;
                this.vip = vip;
                this.sweet = sw;
                this.name = name;
            }
        }
        public class SeatCount
        {
            public int normal, vip, sweet;
            public List<string> Name;
            public string theater, id;
            public SeatCount()
            {
                normal = vip = sweet = 0;
                Name = new List<string>();
                theater = id = string.Empty;
            }
            public void Inc(int type)
            {
                if (type == 1) normal++;
                if (type == 2) vip++;
                if (type == 3) sweet++;
            }
            public void Dec(int type)
            {
                if (type == 1) normal--;
                if (type == 2) vip--;
                if (type == 3) sweet--;
            }
            public bool isEmpty()
            {
                return (normal == 0 && vip == 0 && sweet == 0);
            }
        }
        public class SeatTag
        {
            public int type;
            public string name;
            public SeatTag(int type, string name)
            {
                this.type = type;
                this.name = name;
            }
        }
        public class BuyedSeat
        {
            public string id;
            public List<string> idseats;
            public BuyedSeat()
            {
                id = string.Empty;
                idseats = new List<string>();
            }
            public BuyedSeat(string id, List<string> id_se)
            {
                this.id = id;
                this.idseats = id_se;
            }
            
        }
    }
}
