﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni2_2_a_
{
    class QuickFind
    {
        private int[] id;
        public QuickFind(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++){
                id[i] = i;
            }
        }

        public bool connected(int p, int q)
        {
            return id[p] == id[q];
        }

        public void union(int p, int q)
        {
            int pId = id[p];
            int qId = id[q];
            for (int i = 0; i < id.Length; i++){
                if (id[i] == pId){
                    id[i] = qId;
                }
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
            QuickFind a = new QuickFind(id.Length);
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
