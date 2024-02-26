using homework26_02.Data;
using homework26_02.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string opt;
do
{
    SpeakerDao speakerDao = new SpeakerDao();
    EventDao eventDao = new EventDao();
    ShowMenu();
    Console.WriteLine("Select an operation:");
    opt = Console.ReadLine();
    switch (opt)
    {
        case "1.1":
            //1.1.Create Speakers
            Console.WriteLine("\nEnter new speakers\n\t");
            Console.Write("Fullname: ");
            string fullname = Console.ReadLine();
            Console.Write("Position: ");
            string position = Console.ReadLine();
            Console.Write("Company: ");
            string company = Console.ReadLine();
            Speakers speakers1 = new Speakers { FullName = fullname, Position = position, Company = company };
            speakerDao.Insert(speakers1);
            break;
        case "1.2":
            //1.2. Update Speakers
            Console.WriteLine("\nEnter updated speakers\n\t");
            Console.Write("id: ");
           int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("fullname: ");
            fullname = Console.ReadLine();
            Console.Write("Position: ");
            position = Console.ReadLine();
            Console.Write("Company: ");
            company = Console.ReadLine();
            speakers1 = new Speakers { FullName = fullname, Position = position, Company = company };
            var r = speakerDao.Update(speakers1);
            if (r == 0) Console.WriteLine("Speakers not found");
            else Console.WriteLine("speakers successfully updated");
            break;
        case "1.3":
            //1.3. Get speakers by Id
            Console.WriteLine("\nEnter selected speakers id\n\t");
            Console.Write("id: ");
            id = Convert.ToInt32(Console.ReadLine());
            var data = speakerDao.GetById(id);
            if (data == null) Console.WriteLine("Speakers not found");
            else Console.WriteLine(data);
            break;
        case "1.4":
            //1.4. Get all speakers
            Console.WriteLine("\nAll groups\n\t");
            foreach (var item in speakerDao.GetAll())
            {
                Console.WriteLine(item );
            }
            break;
        case "1.5":
            Console.WriteLine("\nEnter deleted speakers\n\t");
            Console.Write("id: ");
            id = Convert.ToInt32(Console.ReadLine());
            speakerDao.Delete(id);
            break;
        case "2.1":
            break;
        case "2.2":
            break;
        case "2.3":
            break;
        case "0":
            Console.WriteLine("Finish");
            break;
        default:
            Console.WriteLine("Opt is wrong");
            break;

    }

} while (opt != "0");


void ShowMenu()
{
    Console.WriteLine("1.Speakears\n\t");
    Console.WriteLine("1.1. Create Speakers");
    Console.WriteLine("1.2. Update Speakers");
    Console.WriteLine("1.3. Get speakers by Id");
    Console.WriteLine("1.4. Get all speakers");
    Console.WriteLine("1.5. Delete speakers");
    Console.WriteLine("2.Events\n\t");
    Console.WriteLine("2.1. Create events");
    Console.WriteLine("2.2. Get events by Id");
    Console.WriteLine("2.3. Get all events");
    Console.WriteLine("0. Exit");
}

//-Insert(bir event yaradilanda eventdaki speakerlarin id - leri de gonderilsin ve event yardilib derhal o eventin EventSpeaker datalari da insert edilsin)
//- GetById - Event
//- GetAllEvents
//- AddSpeaker - eventId ve speaker id qebul edib db-da eventSpeaker datasi yaradan metod
// - RemoveSpeaker - eventId ve speakerid qebul edib eventspekaer datasini silen metod (meqsed speaker-i o eventdan cixartmaqdir)
// -Delete - id uzre eventi silmek