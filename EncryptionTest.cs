namespace PracticeClass;

using System;
using PracticeClass;
using System.Collections;

public class EncryptionTest
{

    private static ArrayList localEncryptDB = new ArrayList();

    public static void Main(String[] args)
    {
        Console.Clear();
        Console.WriteLine("####### C# Simple Encryption. CSEC and COSC in one go! #######");
        Console.WriteLine("");

        if (localEncryptDB.Count == 0)
        {
            Console.WriteLine("Let's start your first encryption first!");
            InitiateEncryption();
        } 

        else
        {
            Console.WriteLine("To start decryption, enter your Sector:");
            int sector = int.Parse(Console.ReadLine());

            if (sector <= localEncryptDB.Count - 1)
            {
                EncryptWord obEncryption = (EncryptWord) localEncryptDB[sector];
                
                Console.WriteLine("Enter your reference public key to continue: ");

                int key = int.Parse(Console.ReadLine());
                obEncryption.decryptWord(key);
            }

            else
            {
                Console.WriteLine("Sector not found.");
            }
            
        }
    }

    public static void InitiateEncryption()
    {
        Console.WriteLine("Type the desired message to be decrypted:");
        String sMessage = Console.ReadLine();

        Console.WriteLine("Type your public key as a future security reference:");
        int nKey = int.Parse(Console.ReadLine());

        EncryptWord obEncryption = new EncryptWord(sMessage, nKey);
        obEncryption.encryptWord();
        localEncryptDB.Add(obEncryption);
        Console.WriteLine("This encryption is located on Sector {0}", localEncryptDB.Count - 1);

    }
}