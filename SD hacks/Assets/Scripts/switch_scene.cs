using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class switch_scene : MonoBehaviour {


    public Camera cal_camera;
    public Camera sf_camera;
    public Camera sd_camera;
    public void Cal_scene()
    {
        cal_camera.enabled = true;
        sf_camera.enabled = false;
        sd_camera.enabled = false;
    }
    public void Sf_scene()
    {
        cal_camera.enabled = false;
        sf_camera.enabled = true;
        sd_camera.enabled = false;
    }
    public void Sd_scene()
    {
        sd_camera.enabled = true;
        cal_camera.enabled = false;
        sf_camera.enabled = false;
    }

}
