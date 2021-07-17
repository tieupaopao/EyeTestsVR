using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBlurry : MonoBehaviour
{
    public static void addBlurriness() {
        if (BoxBlur.Iterations < 10) {
            BoxBlur.Iterations++;
        }
        if (BoxBlur.DownRes < 4) {
            BoxBlur.DownRes++;
        }
    }
}
