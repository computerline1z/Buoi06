using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06
{
    class StackLinked <T>
    {
        Node<T> first;   // first trỏ đến phần tử đầu Stack
        Node<T> last;    // last trỏ đến phần tử cuối Stack
        int count;       // số phần tử của Stack
        // propeties
        public Node<T> First { get => first; set => first = value; }
        public Node<T> Last { get => last; set => last = value; }
        public int Count { get => count; set => count = value; }

        // Constructor khởi tạo Stack
        public StackLinked()
        {
            first = null;
            last = null;
            count = 0;
        }
        // Stack là cấu trúc vào trước ra sau nên ta chọn cách thêm vào lấy ra như sau :
        //      Thêm vào đầu (first) và láy ra cũng từ đầu (first)

        // Thêm vào stack một phần tử (thêm vào đầu) có data là x
        public void Push(T x)
        {
            //Khởi tạo node mới n có data = x
            Node<T> n = new Node<T>(x);
            //cho n.next trỏ đến first
            n.Next = first;
            //first trỏ tới n
            first = n;
            //đếm count lên 1
            count++;
            //nếu last = null cho last = firrst
            if (last == null)
                last = first;
        }
        // Lấy ra từ Stack một phần tử
        public T Pop()
        {
            // Gọi p là node đầu ( = first)
            Node<T> p = first;
            // Cho first trỏ đến node sau first
            first = first.Next;
            // Trả về data của node p
            count--;
            return p.Data;
        }
        // Lấy giá trị phần tử đầu stack
        public T Peek()
        {
            // Trả về data của first
            return first.Data;
        }
        // Kiểm tra phần tử x có trong Stack hay không
        public bool Contains(T x)
        {
            // Xuất phát node p = first
            Node<T> p = first;
            //Lặp (khi p còn khác null)
            while (p != null)
            {
                // Nếu p.Data = x : sử dụng x.Equals(p.Data)
                // Trả về true
                if (x.Equals(p.Data)) 
                    return true;
                p = p.Next;
            }

            // trả về false
            return false;
        }

        // Xuất Stack, chỉ để kiểm tra
        public void OutStack()
        {
            Node<T> p = first;
            while (p != null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }
    }
}
