using System.Text.RegularExpressions;

namespace RabitaBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kart;
            Console.Title = "RABITABANK ATM";
            DateTime gun = DateTime.Now;
            Console.WriteLine(gun.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("       RABITABANKA XOSH GELMISINIZ!\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
        CARDS:
            Console.WriteLine("      LUTFEN KARTINIZI DAXIL EDINIZ!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            kart = int.Parse(Console.ReadLine());
            string regex = @"^[0 - 9] +$";
            Regex rg = new Regex(regex);

            if (kart.ToString().Length != 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("       Kart reqem sayi 8 olmalidir! \n");
                goto CARDS;
            }
            else
            {
                goto PINCODE;
            }


        PINCODE:
            Console.ForegroundColor = ConsoleColor.White;
            int pin = 4343;
            Console.Write("PIN KODUNUZU DAXIL EDIN: ");
            pin = Convert.ToInt32(Console.ReadLine());
            if (pin != 4343)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("       Yanlish Pin! \n");
                Console.ForegroundColor = ConsoleColor.White;
                goto PINCODE;
            }
            byte dil;
        Language:
            Console.WriteLine();
            Console.WriteLine("       LUTFEN DILI SECHIN:\n");
            Console.WriteLine("1.AZERBAYCAN");
            Console.WriteLine("2.Русский");
            Console.WriteLine("3.ENGLISH");
            dil = Convert.ToByte(Console.ReadLine());

        Currency:

            int balans = 1000;
            int emeliyyat;
            int miqdar;
            int reqem;
            int mebleg;
            int mobil;
            int valyuta;
            int tarif = 1;

            if (dil == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Zehmet olmasa Valyutani secin:");
                Console.WriteLine();
                Console.WriteLine("1.AZN");
                Console.WriteLine("2.USD");
            }
            else if (dil == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Пожалуйста выберите валюту:");
                Console.WriteLine();
                Console.WriteLine("1.AZN");
                Console.WriteLine("2.USD");
            }
            else if (dil == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Please select a currency:");
                Console.WriteLine();
                Console.WriteLine("1.AZN");
                Console.WriteLine("2.USD");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR!!! DUZGUN REQEM QEYD EDIN!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Language;
            }
            valyuta = Convert.ToInt16(Console.ReadLine());
            if (valyuta != 1 && valyuta != 2)
            {
                if (dil == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста выберите правильную цифру!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Currency;
                }
                else if (dil == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select the correct number!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Currency;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zehmet olmasa duzgun reqem qeyd edesiniz!");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto Currency;
                }
            }
        ATM:
            if (dil == 1)
            {
                Console.Clear();
                Console.WriteLine("       Rabitebank ATM");
                Console.WriteLine();
                Console.WriteLine("Zehmet olmasa emeliyyat secin.");
                Console.WriteLine();
                Console.WriteLine("1.Balansi goster:");
                Console.WriteLine("2.Cekeceyiniz mebleg: ");
                Console.WriteLine("3.Yatiracaginiz mebleg: ");
                Console.WriteLine("4.Bashqa karta pul kocurmek: ");
                Console.WriteLine("5.Mobil Nomreye pul kochurmek: ");
                Console.WriteLine("6.Sistemden cixish..");
            }
            else if (dil == 2)
            {
                Console.Clear();
                Console.WriteLine("       Rabitabank ATM");
                Console.WriteLine();
                Console.WriteLine("Пожалуйста, выберите операцию.");
                Console.WriteLine();
                Console.WriteLine("1.Показать баланс:");
                Console.WriteLine("2.Снимать деньги: ");
                Console.WriteLine("3.Депозит: ");
                Console.WriteLine("4.Операция с карты на карту: ");
                Console.WriteLine("5.Положить деньги на номер телефона: ");
                Console.WriteLine("6.Выход из системы..");
            }
            else if (dil == 3)
            {
                Console.Clear();
                Console.WriteLine("       Rabitabank ATM");
                Console.WriteLine();
                Console.WriteLine("Please select a function.");
                Console.WriteLine();
                Console.WriteLine("1.Check your balance:");
                Console.WriteLine("2.Withdraw amount: ");
                Console.WriteLine("3.Deposit: ");
                Console.WriteLine("4.Card to Card operation: ");
                Console.WriteLine("5.Deposit to the Phone Number: ");
                Console.WriteLine("6.Exit the system..");
            }
            emeliyyat = Convert.ToInt16(Console.ReadLine());

            switch (emeliyyat)
            {
                case 1:
                    //Balance
                    if (valyuta == 1)
                    {
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Баланс: " + balans + "AZN\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Balance: " + balans + "AZN\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Balansiniz: " + balans + "AZN" + "-dir\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            break;
                        }
                    }
                    if (dil == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Баланс: " + balans + "$\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                    }
                    else if (dil == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Balance: " + balans + "$\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Balansiniz: " + balans + "$" + "-dir\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    //Withdraw
                    if (dil == 2)
                    {
                        Console.Write("Сколько будете снять? ");
                    }
                    else if (dil == 3)
                    {
                        Console.Write("How much will you take off? ");
                    }
                    else
                    {
                        Console.Write("Ne qeder mebleg cekeceksiniz? ");
                    }
                    miqdar = Convert.ToInt32(Console.ReadLine());
                    if (balans < miqdar)
                    {
                        if (valyuta == 1)
                        {
                            if (dil == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Недостаточный баланс.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Баланс: " + balans + "AZN\n");
                                break;
                            }
                            else if (dil == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Insufficient balance.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balance: " + balans + "AZN\n");
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Emeliyyat ugursuz.YETERSIZ BALANS.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balans: " + balans + "AZN\n");
                                break;
                            }
                        }
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Недостаточный баланс.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Баланс: " + balans + "$\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Insufficient balance.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balance: " + balans + "$\n");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Emeliyyat ugursuz.YETERSIZ BALANS.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balans: " + balans + "$\n");
                        }
                    }
                    else
                    {
                        balans -= miqdar;
                        if (valyuta == 1)
                        {
                            if (dil == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-" + miqdar + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Баланс: " + balans + "AZN\n");
                                break;
                            }
                            else if (dil == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-" + miqdar + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balance: " + balans + "AZN\n");
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-" + miqdar + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balans: " + balans + "AZN\n");
                                break;
                            }
                        }
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "$");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Баланс: " + balans + "$\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "$");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balance: " + balans + "$\n");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "$.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balans: " + balans + "$\n");
                        }
                    }
                    break;
                case 3:
                    //Deposit
                    if (dil == 2)
                    {
                        Console.Write("Сколько вы внесете депозит? ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (dil == 3)
                    {
                        Console.Write("How much will you deposit? ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("Ne qeder mebleg yatiracaksiniz? ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                    }
                    balans += miqdar;
                    if (valyuta == 1)
                    {
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+" + miqdar + "AZN");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Баланс: " + balans + "AZN\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+" + miqdar + "AZN");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Balance: " + balans + "AZN\n");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+" + miqdar + "AZN.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Balans: " + balans + "AZN\n");
                            break;
                        }
                    }
                    if (dil == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+" + miqdar + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Баланс: " + balans + "$\n");
                        break;
                    }
                    else if (dil == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+" + miqdar + "$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Balance: " + balans + "$\n");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+" + miqdar + "$.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Balans: " + balans + "$\n");
                        break;
                    }
                case 4:
                //CARD TO CARD
                CardToCard:
                    if (dil == 2)
                    {
                        Console.WriteLine("Пожалуйста, введите последние 8 номеров карт..");
                    }
                    else if (dil == 3)
                    {
                        Console.WriteLine("Please enter the last 8 numbers of cards.");
                    }
                    else
                    {
                        Console.WriteLine("Zehmet olmasa kartin ustundeki son 8 reqemi daxil edin.");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    reqem = int.Parse(Console.ReadLine());

                    if (reqem.ToString().Length != 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("       Kart reqem sayi 8 olmalidir! \n");
                        goto CardToCard;
                    }
                    else
                    {
                        goto CardToCard2;
                    }

                CardToCard2:
                    Console.ForegroundColor = ConsoleColor.White;
                    if (dil == 2)
                    {
                        Console.WriteLine("Введите сумму:");
                    }
                    else if (dil == 3)
                    {
                        Console.WriteLine("Enter the amount:");
                    }
                    else
                    {
                        Console.WriteLine("Kocurmek istediyiniz meblegi qeyd edin:");
                    }
                    mebleg = Convert.ToInt32(Console.ReadLine());
                    if (mebleg > balans)
                    {
                        if (valyuta == 1)
                        {
                            if (dil == 2)
                            {
                                Console.WriteLine("Недостаточный баланс.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Баланс: " + balans + "AZN\n");
                                break;
                            }
                            else if (dil == 3)
                            {
                                Console.WriteLine("Insufficient balance.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Balance: " + balans + "AZN\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Emeliyyat ugursuz.YETERSIZ BALANS.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Balans: " + balans + "AZN\n");
                                break;
                            }
                        }
                        if (dil == 2)
                        {
                            Console.WriteLine("Недостаточный баланс.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Баланс: " + balans + "$\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.WriteLine("Insufficient balance.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Balance: " + balans + "$\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Emeliyyat ugursuz.YETERSIZ BALANS.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Balans: " + balans + "$\n");
                        }
                    }
                    else
                    {
                        balans -= mebleg;
                        if (valyuta == 1)
                        {
                            if (dil == 2)
                            {
                                Console.Write("Сумма перевода: " + "-");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(mebleg + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Баланс: " + balans + "AZN\n");
                                break;
                            }
                            else if (dil == 3)
                            {
                                Console.Write("Amount transferred: " + "-");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(mebleg + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balance: " + balans + "AZN\n");
                                break;
                            }
                            else
                            {
                                Console.Write("Kocurulen mebleg: " + "-");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(mebleg + "AZN");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Balans: " + balans + "AZN\n");
                                break;
                            }
                        }
                        if (dil == 2)
                        {
                            Console.Write("Сумма перевода: " + "-");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(mebleg + "$");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Баланс: " + balans + "$\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.Write("Amount transferred: " + "-");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(mebleg + "$");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balance: " + balans + "$\n");
                            break;
                        }
                        else
                        {
                            Console.Write("Kocurulen mebleg: " + "-");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Kocurulen mebleg: " + "-" + mebleg + "$");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balans: " + balans + "$\n");
                            break;
                        }
                    }
                    break;
                case 5:
                //MOBIL OPERATORLAR
                OPERATOR:
                    if (dil == 2)
                    {
                        Console.WriteLine("Выберите оператора мобильной связи:\n");
                        Console.WriteLine("1.Azercell");
                        Console.WriteLine("2.Bakcell");
                        Console.WriteLine("3.Nar");
                    }
                    else if (dil == 3)
                    {
                        Console.WriteLine("Choose the mobile operator:\n");
                        Console.WriteLine("1.Azercell");
                        Console.WriteLine("2.Bakcell");
                        Console.WriteLine("3.Nar");
                    }
                    else
                    {
                        Console.WriteLine("Mobil Operatoru Sechin:\n");
                        Console.WriteLine("1.Azercell");
                        Console.WriteLine("2.Bakcell");
                        Console.WriteLine("3.Nar");
                    }
                    tarif = Convert.ToInt32(Console.ReadLine());
                    if (tarif == 1)
                    {
                        if (dil == 2)
                        {
                            Console.WriteLine("Пожалуйста, введите номер мобильного телефона:");
                            Console.Write("+9945");
                        }
                        else if (dil == 3)
                        {
                            Console.WriteLine("Please enter the mobile number:");
                            Console.Write("+9945");
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa mobil nomresini daxil edin:");
                            Console.Write("+9945");

                        }
                        mobil = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (tarif == 2)
                    {
                        if (dil == 2)
                        {
                            Console.WriteLine("Пожалуйста, введите номер мобильного телефона:");
                            Console.Write("+9945");
                        }
                        else if (dil == 3)
                        {
                            Console.WriteLine("Please enter the mobile number:");
                            Console.Write("+9945");
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa mobil nomresini daxil edin:");
                            Console.Write("+9945");
                        }
                        mobil = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (tarif == 3)
                    {
                        if (dil == 2)
                        {
                            Console.WriteLine("Пожалуйста, введите номер мобильного телефона:");
                            Console.Write("+9947");
                        }
                        else if (dil == 3)
                        {
                            Console.WriteLine("Please enter the mobile number:");
                            Console.Write("+9947");
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa mobil nomresini daxil edin:");
                            Console.Write("+9947");
                        }
                        mobil = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR! Выберите правильную оператору!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto OPERATOR;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR! Choose the right operator!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto OPERATOR;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR! DUZGUN OPERATOR SECHIN!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto OPERATOR;
                        }
                    }
                    if (dil == 2)
                    {
                        Console.Write("Введите сумму: ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                        balans -= miqdar;
                    }
                    else if (dil == 3)
                    {
                        Console.Write("Enter the amount: ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                        balans -= miqdar;
                    }
                    else
                    {
                        Console.Write("Kochureceyiniz meblegi qeyd edin: ");
                        miqdar = Convert.ToInt32(Console.ReadLine());
                        balans -= miqdar;
                    }
                    if (valyuta == 1)
                    {
                        if (dil == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "AZN");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Баланс: " + balans + "AZN\n");
                            break;
                        }
                        else if (dil == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "AZN");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balance: " + balans + "AZN\n");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-" + miqdar + "AZN");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Balans: " + balans + "AZN\n");
                            break;
                        }
                    }
                    if (dil == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-" + miqdar + "$");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Баланс: " + balans + "$\n");
                        break;
                    }
                    else if (dil == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-" + miqdar + "$");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Balance: " + balans + "$\n");
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-" + miqdar + "$");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Balans: " + balans + "$\n");
                        break;
                    }
                case 6:
                    //EXIT
                    if (dil == 2)
                    {
                        Console.WriteLine("Выход из системы..\n");
                    }
                    else if (dil == 3)
                    {
                        Console.WriteLine("Exit the system..\n");
                    }
                    else
                    {
                        Console.WriteLine("Sistemden cixilir..\n");
                    }
                    goto EXIT;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("         ERROR!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto EXIT;
            }

            int emeliyyat2;
            if (dil == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Спасибо! Хотите снова работать?\n");
            }
            else if (dil == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Thank you! Do you want to operate again?\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Teshekkur edirik! Yeniden emeliyyat etmek isteyirsiz?\n");
            }
        emeliyyat:
            if (dil == 2)
            {
                Console.WriteLine("1.Продолжать:");
                Console.WriteLine("2.Отказатся:");
            }
            else if (dil == 3)
            {
                Console.WriteLine("1.Continue:");
                Console.WriteLine("2.Refuse:");
            }
            else
            {
                Console.WriteLine("1.Davam etmek:");
                Console.WriteLine("2.Imtina etmek:");
            }
            emeliyyat2 = Convert.ToInt32(Console.ReadLine());

            switch (emeliyyat2)
            {
                case 1:
                    goto ATM;
                case 2:
                    break;
                default:
                    if (dil == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!!! Неправильная цифра. Пожалуйста, выберите правильный цифру!\n");
                    }
                    else if (dil == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!!! Wrong number. Please choose the correct number!\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!!! Yanlish reqem girdiniz. Zehmet olmasa duzgun reqemi qeyd edesiniz!\n");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    goto emeliyyat;
            }
        EXIT:
            if (dil == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     TESHEKKURLER!\n");
                Console.WriteLine("  Kartinizi goturun!");
            }
            else if (dil == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  Спасибо за операцию!\n");
                Console.WriteLine(" Возьмите свою карточку!");
            }
            else if (dil == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you for the operation!\n");
                Console.WriteLine("     Take your card!");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
        }
    }
}