using System;
using System.Collections.Generic;
using System.Text;

namespace pintApp2
{
    public class TagRFID
    {
        private string _rfid;
        private string _tag;

        public string RFID
        {
            get { return _rfid; }
            set { _rfid = value; }
        }

        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        /*public static bool operator == (TagRFID other1, TagRFID other2)
        {
            return (other1._rfid == other2._rfid) && (other1._tag == other2._tag);
        }

        public static bool operator !=(TagRFID other1, TagRFID other2)
        {
            return (other1._rfid != other2._rfid) || (other1._tag != other2._tag);
        }*/

        public TagRFID(string Tag, string RFID)
        {
            _rfid = RFID;
            _tag = Tag;
        }

        /*public TagRFID()
        {
            _rfid = _tag = "";
        }*/
    }

    public class TagBurner
    {
        private List<TagRFID> tags = new List<TagRFID>();
        private string addr;
        public string Address { get; set; }

        private string findNextEmptyTag()
        {
            for (int i = 0; ; i++)
            {
                bool isFound = false;
                foreach (var t in tags)
                {
                    if (t.Tag.EndsWith(i.ToString()))
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                    continue;

                return i.ToString();
            }
        }

        public string addNewTagRFID(string rfid)
        {
            rfid = convertToValidString(rfid.Trim());
            var tag = findNextEmptyTag();
            tags.Add(new TagRFID(tag, rfid));
            return tag;
        }

        public void changeTag(string rfid, string tag)
        {
            try
            {
                tags.Find(x => x.RFID == rfid).Tag = tag;
            }
            catch (System.ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                tags.Add(new TagRFID(tag, rfid));
            }
        }

        public TagBurner(string address="")
        {
            //-- If there were no address specified...
            if (address == "") return;
            addr = address;
            open(address);
        }

        public string tag2RFID(string tag)
        {
            tag = tag.Trim();
            try
            {
                return tags.Find(x => x.Tag == tag).RFID;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("can not found Tag");
                throw ex;
            }
        }

        public string RFID2tag(string RFID)
        {
            RFID = RFID.Trim();
            try
            {
                return tags.Find(x => x.RFID == RFID).Tag;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("can not found RFID");
                throw ex;
            }
        }

        public void save(string address="")
        {
            if (address == "") address = addr;
            else addr = address;

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(address, false);
                foreach (TagRFID t in tags)
                    file.WriteLine(t.Tag + "=" + t.RFID);
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void open(string address="")
        {
            string line;
            if (address == "") address = addr;
            else addr = address;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(address);
                while ((line = file.ReadLine()) != null)
                    processLine(line);
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        //-- Reading Data from file
        private void processLine(string line)
        {
            string tag="", rfid="";
            string phrase = "";
            bool isFirstPart = true;
            for (int c = 0; c < line.Length; ++c)
            {
                //-- Skip comments
                if (line[c] == ';')  break;
                if (line[c] == '=')
                {
                    phrase = phrase.Trim();
                    if (isFirstPart)
                        tag = phrase;
                    else
                        rfid = phrase;
                    isFirstPart = false;
                    phrase = "";
                    continue;
                }
                    
                phrase += line[c];
            } // [END FOR]

            if (phrase != "")
                rfid += phrase;

            tags.Add(new TagRFID(tag, convertToValidString(rfid.Trim())));
        } // [END PROCESS_LINE]


        const string VALID_CHARACTERS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";

        public static string convertToValidString(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (var c in input)
            {
                if (VALID_CHARACTERS.IndexOf(c) >= 0)
                    result.Append(c);
            }

            return result.ToString();
        }

    } // [END TAG_BURNER]
} // [END NAMESPACE]