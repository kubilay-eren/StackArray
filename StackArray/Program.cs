using System;

namespace StackArray
{
    public class Program
    {
        public class MyStacks
        {
            public int[] arr; // yığınları depolamak için kullanacağım dizi. 
            public int[] top; // yığının üst dizinlerinin depolanacağı dizi
            public int[] next; // yeni dizini yığınlara kaydetebilmek için kullanılacak dizi
            public int n, k;
            public int free; 

            
            public MyStacks(int k1, int n1)
            {
                k = k1;
                n = n1;
                arr = new int[n];
                top = new int[k];
                next = new int[n];

                for (int i = 0; i < k; i++)
                {
                    top[i] = -1;
                }

                free = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    next[i] = i + 1;
                }
                next[n - 1] = -1; // listenin sonunda olduğumuzu anlamak için -1 parametresini kullancağım
            }

            // dizi full mu kontrolü yapacağımız metod
            public virtual bool Full
            {
                get
                {
                    return (free == -1);
                }
            }

            // diziye eleman ekleyebileceğimiz metod  
            public virtual void push(int item, int sn)
            {
                if (Full)
                {
                    Console.WriteLine("Yığın dolu");
                    return;
                }

                int i = free; 

                // boş olan indeksi setle 
                free = next[i];

                // yığın numarasını güncelle
                next[i] = top[sn];
                top[sn] = i;

                // diziye eleman ekle 
                arr[i] = item;
            }

            // eleman sileceğimiz metod 
            public virtual int pop(int sn)
            {
                // 
                if (isEmpty(sn))
                {
                    Console.WriteLine("yığın boş");
                    return int.MaxValue;
                }

                int i = top[sn];

                top[sn] = next[i]; 

                
                next[i] = free;
                free = i;

                return arr[i];
            }

            
            public virtual bool isEmpty(int sn)
            {
                return (top[sn] == -1);
            }

        }

        
        public static void Main(string[] args)
        {
           
            int k = 3, n = 10; // 1o elemanlı 3 yığın içeren dizi

            MyStacks ks = new MyStacks(k, n);

            ks.push(15, 2);
            ks.push(45, 2);

            ks.push(17, 1);
            ks.push(49, 1);
            ks.push(39, 1);

            ks.push(11, 0);
            ks.push(9, 0);
            ks.push(7, 0);

            Console.WriteLine("3. yığından çıkarılan eleman " + ks.pop(2));
            Console.WriteLine("2. yığından çıkarılan eleman" + ks.pop(1));
            Console.WriteLine("1. yığından çıkarılan eleman " + ks.pop(0));
        }
    }

}
