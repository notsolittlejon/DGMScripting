using UnityEngine;
using System.Collections;

public class Book : MonoBehaviour {
	public enum Chapters{Chapter_1, Chapter_2, Chapter_3, Chapter_4};
	public Chapters ChapterNumber;


	void ChangeChapter()
	{
		switch (ChapterNumber) {
		case Chapters.Chapter_1:
			print ("Chapter 1");
			print ("Our Adventure Begins.");
			print (".......................");
			break;

		case Chapters.Chapter_2:
			print("Chapter 2");
			print ("Our Adventure Continues.");
			print (".......................");
			break;

		case Chapters.Chapter_3:
			print ("Chapter 3");
			print ("Our Adventure Keeps on Going!.");
			print (".......................");
			break;

		case Chapters.Chapter_4:
			print ("Chapter 4");
			print ("Our Adventure Comes to a dramatic conclusion...");
			print (".......................");
			break;
		}
	}
	void OnMouseDown(){
		ChangeChapter();
	}
}
