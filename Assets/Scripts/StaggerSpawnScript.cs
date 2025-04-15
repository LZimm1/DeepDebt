using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaggerSpawnScript : MonoBehaviour
{
    public Transform TipMenu;
    public Transform TipImage;
    public Transform InvestMenu;
    public Transform InvestImage;
    public Transform GambleMenu;
    public Transform GambleImage;
    public Transform NFTMenu;
    public Transform NFTImage;
    public Transform DonateMenu;
    public Transform DonateImage;
    public Transform burnUpgrade;
    public Transform tipUpgrade;
    public Transform investUpgrade;
    public Transform gambleUpgrade;
    public Transform NFTUpgrade;
    public Transform donateUpgrade;
    
    private Vector3 TipMenuPos;
    private Vector3 TipImagePos;
    private Vector3 InvestMenuPos;
    private Vector3 InvestImagePos;
    private Vector3 GambleMenuPos;
    private Vector3 GambleImagePos;
    private Vector3 NFTMenuPos;
    private Vector3 NFTImagePos;
    private Vector3 DonateMenuPos;
    private Vector3 DonateImagePos;
    private Vector3 burnUpgradePos;
    private Vector3 tipUpgradePos;
    private Vector3 investUpgradePos;
    private Vector3 gambleUpgradePos;
    private Vector3 NFTUpgradePos;
    private Vector3 donateUpgradePos;

    // Start is called before the first frame update
    void Start()
    {
        TipMenuPos = TipMenu.position;
        TipImagePos = TipImage.position;
        InvestMenuPos = InvestMenu.position;
        InvestImagePos = InvestImage.position;
        GambleMenuPos = GambleMenu.position;
        GambleImagePos = GambleImage.position;
        NFTMenuPos = NFTMenu.position;
        NFTImagePos = NFTImage.position;
        DonateMenuPos = DonateMenu.position;
        DonateImagePos = DonateImage.position;
        burnUpgradePos = burnUpgrade.position;
        tipUpgradePos = tipUpgrade.position;
        investUpgradePos = investUpgrade.position;
        gambleUpgradePos = gambleUpgrade.position;
        NFTUpgradePos = NFTUpgrade.position;
        donateUpgradePos = donateUpgrade.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(UIScript.money > 999999900){
            TipMenu.position = new Vector3(10000f,0f,0f);
            TipImage.position = new Vector3(100000f,0f,0f);
        }
        else{
            TipMenu.position = TipMenuPos;
            TipImage.position = TipImagePos;
        }
        if(UIScript.money > 999999000){
            InvestMenu.position = new Vector3(100000f,0f,0f);
            InvestImage.position = new Vector3(100000f,0f,0f);
        }
        else{
            InvestMenu.position = InvestMenuPos;
            InvestImage.position = InvestImagePos;
        }
        if(UIScript.money > 999980000){
            GambleMenu.position = new Vector3(10000f,0f,0f);
            GambleImage.position = new Vector3(100000f,0f,0f);
        }
        else{
            GambleMenu.position = GambleMenuPos;
            GambleImage.position = GambleImagePos;
        }
        if(UIScript.money > 985000000){
            NFTMenu.position = new Vector3(100000f,0f,0f);
            NFTImage.position = new Vector3(100000f,0f,0f);
        }
        else{
            NFTMenu.position = NFTMenuPos;
            NFTImage.position = NFTImagePos;
        }
        if(UIScript.money > 980000000){
            DonateMenu.position = new Vector3(100000f,0f,0f);
            DonateImage.position = new Vector3(100000f,0f,0f);
        }
        else{
            DonateMenu.position = DonateMenuPos;
            DonateImage.position = DonateImagePos;
        }
        if(UIScript.money > 999990000){
            burnUpgrade.position = new Vector3(100000f,0f,0f);
        }
        else{
            burnUpgrade.position = burnUpgradePos;
        }
        if(UIScript.money > 999945000){
            tipUpgrade.position = new Vector3(100000f,0f,0f);
        }
        else{
            tipUpgrade.position = tipUpgradePos;
        }
        if(UIScript.money > 999000000){
            investUpgrade.position = new Vector3(100000f,0f,0f);
        }
        else{
            investUpgrade.position = investUpgradePos;
        }
        if(UIScript.money > 995000000){
            gambleUpgrade.position = new Vector3(100000f,0f,0f);
        }
        else{
            gambleUpgrade.position = gambleUpgradePos;
        }
        if(UIScript.money > 975000000){
            NFTUpgrade.position = new Vector3(1000000f,0f,0f);
        }
        else{
            NFTUpgrade.position = NFTUpgradePos;
        }
        if(UIScript.money > 800000000){
            donateUpgrade.position = new Vector3(10000f,0f,0f);
        }
        else{
            donateUpgrade.position = donateUpgradePos;
        }
    }
}
