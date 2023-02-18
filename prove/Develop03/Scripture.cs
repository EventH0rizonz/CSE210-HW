class scripture {
private string _reference;
private string _scripture;
private Random randomGenerator = new Random();
private List<string> _scriptures = new List<string>() {
    "3 Nephi 11-->For verily, verily I say unto you, he that hath the spirit of acontention is not of me, but is of the bdevil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another.",
    "1 Samuel 16-->But the Lord said unto Samuel, Look not on his countenance, or on the height of his stature; because I have refused him: for the Lord seeth not as man seeth; for man looketh on the outward cappearance, but the Lord looketh on the eheart.",
    "Isaiah 1:18-->Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."
    };
private List<string> _multiScriptures = new List<string>() {
        "Malachi 4:5-6-->Behold, I will asend you Elijah the prophet before the coming of the great and dreadful day of the Lord: And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.",
        "D&C 8:2-3-->Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.",
        "Colossians 3:9-10-->Lie not one to another, seeing that ye have put off the old man with his deeds;10 And have put on the new man, which is renewed in knowledge after the image of him that created him:"
    };
public string GiveScripture() {
    return _scripture;
    }
public string GiveReference() {
        return _reference;
    }
public scripture() {
    int scriptureType = randomGenerator.Next(10);
    Console.WriteLine(scriptureType);
    if (scriptureType >= 5) 
    {
            GiveSingleScripture();
    }
    else
    {
            GiveMultiScripture();
    }
}
private void GiveMultiScripture() {
    int randScripture = randomGenerator.Next(0,_multiScriptures.Count());
    string fullScript = _multiScriptures[randScripture];
    string[] parts = fullScript.Split("-->");
    _reference = parts[0];
    _scripture = parts[1];
}
private void GiveSingleScripture() {
    int randScripture = randomGenerator.Next(0,_scriptures.Count());
    string fullScript = _scriptures[randScripture];
    string[] parts = fullScript.Split("-->");
    _reference = parts[0];
    _scripture = parts[1];
    }
}