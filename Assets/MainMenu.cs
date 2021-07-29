using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

public GameObject garagePnl,settingPnl,mainPnl,controllerpnl,graphicspnl,audiopnl;
public GameObject[] quality;
public string privacy,rateus,moregames,ads;
public void GaragePanel(bool x)
{
  garagePnl.SetActive(x);
}
 public void SettingPanel(bool x)
 {
    settingPnl.SetActive(x);
 }
 public void Controller(bool x)
 {
   controllerpnl.SetActive(x);
   graphicspnl.SetActive(!x);
   audiopnl.SetActive(!x);
 }
  public void Graphics(bool x)
 {
   controllerpnl.SetActive(!x);
   graphicspnl.SetActive(x);
   audiopnl.SetActive(!x);
 }
  public void Audio(bool x)
 {
   controllerpnl.SetActive(!x);
   graphicspnl.SetActive(!x);
   audiopnl.SetActive(x);
 }
 public void Checked(string s)
 {
     if(s=="sh")
     {
       if(EventSystem.current.currentSelectedGameObject.GetComponent<Toggle>().isOn)
       {
         QualitySettings.shadows=ShadowQuality.All;
           Debug.Log("Shadow on ");
       }
       else
       {
         QualitySettings.shadows=ShadowQuality.Disable;
           Debug.Log("Shadow off ");
       }
     }
     else if(s=="so")
     {
       if(EventSystem.current.currentSelectedGameObject.GetComponent<Toggle>().isOn)
       {
           Debug.Log("sound on ");
       }
       else
       {
           Debug.Log("sound off ");
       }
     }
     else if(s=="mu")
     {
       if(EventSystem.current.currentSelectedGameObject.GetComponent<Toggle>().isOn)
       {
           Debug.Log("music on ");
       }
       else
       {
           Debug.Log("musici off ");
       }
     }

 }
 public void Graphicsbtn(int x)
 {

  QualitySettings.SetQualityLevel(((x+1)==4)?5:((x+1)==5)?0:(x+1),true);
   quality[x].SetActive(false);
   if(x<quality.Length-1)
   {
    quality[x+1].SetActive(true);
   }
   else
   {
    quality[0].SetActive(true);
   // QualitySettings.SetQualityLevel(0,true);
   }
 }
 public void ControllerBtn(string s)
 {
   if(s=="b")
   {
    RCC_Settings.Instance.mobileController=RCC_Settings.MobileController.TouchScreen;
   }
   else if(s=="s")
   {
    RCC_Settings.Instance.mobileController=RCC_Settings.MobileController.SteeringWheel;    
   }   
   else if(s=="g")
   {
    RCC_Settings.Instance.mobileController=RCC_Settings.MobileController.Gyro;    
   }   
   else if(s=="j")
   {
    RCC_Settings.Instance.mobileController=RCC_Settings.MobileController.Joystick;
   }
 }
 public void Privacy()
 {
   Application.OpenURL(privacy);
 }
 public void Rateus()
 {
   Application.OpenURL(rateus+Application.identifier);
 }
  public void MoreGames()
 {
   Application.OpenURL(moregames);
 } public void Ads()
 {
   Application.OpenURL(ads);
 }
}
