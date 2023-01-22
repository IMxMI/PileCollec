using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 1. Pourquoi l'attribut sommet à été mis en commentaire ? : Cet attribut à était mis en commentaire car la arraylist fonctionne différament que le tableau

 */

namespace PileCollection
{
    class Program
    {

        struct Pile
        {
            public int maxElt; //nombre maximum d'éléments de la pile
            //public int sommet; //indice du sommet (dernier élément empilé)
            public ArrayList tabElem; //tableau [0..Maxelt] d'entiers
        }


        static void Main(string[] args)
        {
            try
            {
                TestPileVidePleine(5);
                TestEmpiler(5);
                TestEmpilerDepiler(5);
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fin du programme, Appuyez sur une touche pour terminer");
            Console.ReadKey();
        }

        ///<summary>
        ///Initialise la nouvelle variable de type Pile
        ///cette méthode :
        ///     initialise la variable maxElt
        ///     instancie la collection de type ArrayList tabElem
        /// </summary>
        /// <param name="pUnePile">Pile à initialiser</param>
        /// <param name="PNbElment">Nombre d'élément maxi de la Pile</param>
        static void InitPile(ref Pile pUnePile, int PNbElemt)
        {
            pUnePile.maxElt = PNbElemt;
            pUnePile.tabElem = new ArrayList();
        }

        /// <summary>
        /// Retourne un booléen indiquant si la pile est vide.
        /// Une pile est vide si la valeur de arraylist est égal à 0.
        /// 
        /// </summary>
        /// <param name="pUnePile">Pile dont l'on veut vérifier le contenue</param>
        static bool PileVide(Pile pUnePile)
        {
            return pUnePile.tabElem.Count == 0;
        }

        /// <summary>
        /// Retourne un booléen indiquant si la pile est pleine.
        /// Une pile est pleine lorsque que arraylist est égal à maxElt
        /// 
        /// </summary>
        /// <param name="pUnePile">Pile dont l'on veut vérifier le contenue</param>
        static bool PilePleine(Pile pUnePile)
        {
            return pUnePile.maxElt == pUnePile.tabElem.Count;
        }

        static void Empiler(ref Pile pUnePile, Object PObj)
        {
            
                if (!PilePleine(pUnePile))
                {
                    pUnePile.tabElem.Add(PObj);
                }
                else
                {
                    throw new Exception("Pile pleine, impossible d'empiler un élément");
                    //throw new Exception("Pile pleine, impossible d'empiler un élément");
                }

            

            }

        static object Depiler(ref Pile pUnePile)
        {
            if (!PileVide(pUnePile))
            {
                int result = (int)pUnePile.tabElem[pUnePile.tabElem.Count-1];
                pUnePile.tabElem.Remove(pUnePile.tabElem.Count - 1);
                return result;
            }
            else
            {
                throw new Exception("Pile vide, impossible de d'épiler un élément");
            }
        }

        static void TestPileVidePleine(int nbElements)
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, nbElements);
            if (PileVide(unePile))
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (PilePleine(unePile))
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }

        }

        /// <summary>
        /// Test l'empilement
        /// </summary>
        /// <param name="nbElements"></param>
        static void TestEmpiler(int nbElements)
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, nbElements);
            Empiler(ref unePile, 2);
            Empiler(ref unePile, 14);
            Empiler(ref unePile, 6);
        }

        static void TestEmpilerDepiler(int nbElements)
        {
            Pile unePile = new Pile();
            InitPile(ref unePile, 5);
            Empiler(ref unePile, 2);
            Empiler(ref unePile, 22);
            int ValeurDepilee = (int)Depiler(ref unePile);
            Console.WriteLine("Valeur dépilée : " + ValeurDepilee);
            Empiler(ref unePile, 17);
            ValeurDepilee = (int)Depiler(ref unePile);
            ValeurDepilee = (int)Depiler(ref unePile);
            ValeurDepilee = (int)Depiler(ref unePile);
            ValeurDepilee = (int)Depiler(ref unePile);

        }

        static string Convertir(int pNbElements, int pNbAConvertir, Int32 PNewBase)
        {
            String resultat = "";
            int premierNombre = pNbAConvertir;
            Pile pileConvertion = new Pile();
            InitPile(ref pileConvertion, pNbElements);
            while (pNbAConvertir != 0 && !PilePleine(pileConvertion))
            {
                Empiler(ref pileConvertion, pNbAConvertir % PNewBase);
                pNbAConvertir /= PNewBase;
            }
            if (pNbAConvertir != 0)
            {
                throw new Exception("Impossible de convertir, la pile est trop petite");
            }
            else
            {
                while (!PileVide(pileConvertion))
                {
                    int nb = Depiler(ref pileConvertion);
                    if ()
                    resultat += Convert.ToString(nb);
            }


        }






    }
    }

