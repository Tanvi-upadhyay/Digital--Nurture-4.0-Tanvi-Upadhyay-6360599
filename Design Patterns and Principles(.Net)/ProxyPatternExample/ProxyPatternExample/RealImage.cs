using System;
public class RealImage : Image {

    private string filename;
    public RealImage(string filename) {
        this.filename = filename;
        LoadFromDisk();
    }
    private void LoadFromDisk() {
        Console.WriteLine("Loading " + filename);
    }
    public void Display() {
        Console.WriteLine("Displaying " + filename);
    }
}
