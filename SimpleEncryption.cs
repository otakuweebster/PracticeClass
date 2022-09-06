using System;
namespace PracticeClass;

public class EncryptWord
{
    private String clearText;
    private String EncryptedText;
    private int key;

    public EncryptWord(String sWord, int userKey)
    {
        clearText = sWord;
        key = userKey;
    }

    public void encryptWord()
    {
        char[] chars = clearText.ToCharArray();
        foreach(char i in chars)
        {
            if (!i.Equals(' '))
            {
                EncryptedText = "" + (i + 2);
            }
        }

        Console.WriteLine("Encryption is finished! Hold on with your public key as it will be used to decrypt the text back again");
    }

    public void decryptWord(int givenKey)
    {
        if (givenKey != key)
        {
            Console.WriteLine("Incorrect Public Key. As a security measure, encryption cannot go through without a specific public key");
        }

        else
        {
            if (EncryptedText.Length == 0)
            {
                Console.WriteLine("You have not Encrypted the text yet!");
            }
            
            else
            {
                char[] chars = EncryptedText.ToCharArray();
                String decrpyted = "";

                foreach(char i in chars)
                {
                    if (!i.Equals(' '))
                    {
                        decrpyted = "" + (i - 2);
                    }
                }

                Console.WriteLine("Your decrypted text is as following: {0}", decrpyted);
            }
        }
    }
}
