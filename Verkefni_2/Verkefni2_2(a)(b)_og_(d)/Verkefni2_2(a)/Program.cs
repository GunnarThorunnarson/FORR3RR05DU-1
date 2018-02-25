using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni2_2_a_
{
    /*
     * 
     * a)
     *   Búðu til class sbr.  leiðbeiningum í áfanganum Algorithms Part1 - Union Find sem úfæra eftirfarandi reiknirit
     * 
     *   Quick-Find
     *   Quick-Union
     *   Weighted Quick-Union
     *   Weighted Quick-Union + path compression
     * 
     * 
     * 
     * b)
     *  Búðu til test client forrit sem prófar ofangreinda klasa með úrtaksgögnum (e. sample data) 10
     *  objectar og eftirfarandi upphafsstöðu (union aðgerðir); 
     *  (4,3), (3,8), (6,5), (9,4), (2,1), (7,4)
     * 
     */ 
    class Program
    {

        static void Main(string[] args)
        {
            //Importa klasana
            QuickFind quickFind = new QuickFind(10);
            QuickUnion quickUnion = new QuickUnion(10);
            WeightedQuickUnion wQuickUnion = new WeightedQuickUnion(10);
            WeightedQuickUnionPathCompression wQuickUnionPath = new WeightedQuickUnionPathCompression(10);



            //Kalla í test functionin
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quick Find Test: ");
            quickFind.test();
            Console.WriteLine("\nQuick Union Test: ");
            quickUnion.test();
            Console.WriteLine("\nWeighted Quick Union Test: ");
            wQuickUnion.test();
            Console.WriteLine("\nWeighted Quick Union + Path Compression Test: ");
            wQuickUnionPath.test();

            Console.WriteLine("\n\n\nLiður D");
            Console.WriteLine("\nQuick Find: ");
            quickFind.LidurD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nQuick Union:");
            quickUnion.LidurD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWeighted Quick Union: ");
            wQuickUnion.LidurD();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWeighted Quick Union + Path Compression: ");
            wQuickUnionPath.LidurD();
            Console.ReadLine();


        }
    }
}
