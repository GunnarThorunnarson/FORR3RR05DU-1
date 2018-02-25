using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni2_2_a_
{
    class WeightedQuickUnion
    {
        private int[] id;
        private int[] sz;

        public WeightedQuickUnion(int n)
        {
            id = new int[n];
            sz = new int[n];
            for (int i = 0; i < n; i++){
                id[i] = i;
                sz[i] = 1;
            }
        }
        private int root(int i)
        {
            while (i != id[i]){
                i = id[i];
            }
            return i;
        }
        public bool connected(int p, int q)
        {
            return root(p) == root(q);
        }
        public void union(int p, int q)
        {
            int i = root(p);
            int j = root(q);
            if (i == j){
                return;
            }
            if (sz[i] < sz[j]){
                id[i] = j;
                sz[j] += sz[i];
            }
            else{
                id[j] = i;
                sz[i] += sz[j];
            }
        }
        public void test()
        {
            union(4, 3);
            union(3, 8);
            union(6, 5);
            union(9, 4);
            union(2, 1);
            union(7, 4);

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < id.Length; i++){
                Console.Write(id[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void print()
        {
            for (int j = 0; j < id.Length; j++)
            {
                Console.Write(id[j] + " ");
            }
        }
        public void LidurD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WeightedQuickUnion a = new WeightedQuickUnion(id.Length);
            for (int i = 0; i < id.Length - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Tengja " + i + " við " + (i + 1) + ":\t ");
                Console.ForegroundColor = ConsoleColor.Red;

                a.union(i, i + 1);
                a.print();
                Console.WriteLine();
            }
        }

    }
}
