using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    private bool burnUpgrade1;
    private bool burnUpgrade2;
    private bool tipUpgrade1;
    private bool tipUpgrade2;
    private bool investUpgrade1;
    private bool investUpgrade2;
    private bool gambleUpgrade1;
    private bool gambleUpgrade2;
    private bool NFTUpgrade1;
    private  bool NFTUpgrade2;
    private bool DonateUpgrade1;
    private bool DonateUpgrade2;
    
    public Text burnUpgrade1Text;
    public Text burnUpgrade2Text;
    public Text tipUpgrade1Text;
    public  Text tipUpgrade2Text;
    public Text investUpgrade1Text;
    public Text investUpgrade2Text;
    public Text gambleUpgrade1Text;
    public Text gambleUpgrade2Text;
    public Text NFTUpgrade1Text;
    public  Text NFTUpgrade2Text;
    public Text DonateUpgrade1Text;
    public Text DonateUpgrade2Text;

    public Slider BurnSlider;
    public Slider TipSlider;
    public Slider InvestSlider;
    public Slider GambleSlider;
    public Slider NFTSlider;
    public Slider DonateSlider;
    public static long money =1000000000;
    private int moneyBurned = 10;
    private int moneyTipped = 100;
    private int moneyInvested = 1000;
    private int moneyGambled = 10000;
    private int moneyLostByNFT = 100000;
    private int moneyDonated = 1000000;
    public Text moneyText;
    public Text moneyBurnText;
    public Text moneyTippedText;
    public Text moneyInvestedText;
    public Text moneyGambledText;
    public Text moneyLostByNFTText;
    public Text moneyDonatedText;

    // Audio
    public AudioSource upgradeSound;
    public AudioSource buySound1;
    public AudioSource buySound2;
    public AudioSource buySound3;

    public static bool ready = false;
    // Start is called before the first frame update
    void Start()
    {
        BurnSlider.value = 1;
        TipSlider.value = 1;
        InvestSlider.value = 1;
        GambleSlider.value = 1;
        NFTSlider.value = 1;
        DonateSlider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        moveSliders();
        if(money < -9000000000000000000){
            money = -9000000000000000000;
        }
        // Texts
        if(moneyText){
            moneyText.text = "Money: $" + string.Format("{0:#,###0}", money);
        }
        if(moneyBurnText){
            if(burnUpgrade1==false){
                moneyBurnText.text= "-$10";
            }
            else{
                moneyBurnText.text = "-$1,000";
            }
        }
        if(moneyTippedText){
            if(tipUpgrade1==false){
                moneyTippedText.text = "-$100";
            }
            else{
                moneyTippedText.text = "-$10,000";
            }
        }
        if(moneyInvestedText){
            if(investUpgrade1==false){
                moneyInvestedText.text = "-$1,000";
            }
            else{
                moneyInvestedText.text = "-$100,000";
            }
        }
        if(moneyGambledText){
            if(gambleUpgrade1==false){
                moneyGambledText.text = "-$10,000";
            }
            else{
                moneyGambledText.text = "-$1,000,000";
            }
        }
        if(moneyLostByNFTText){
            if(NFTUpgrade1==false){
                moneyLostByNFTText.text = "-$100,000";
            }
            else{
                moneyLostByNFTText.text = "-$10,000,000";
            }
        }
        if(moneyDonatedText){
            if(DonateUpgrade1==false){
                moneyDonatedText.text = "-$1,000,000";
            }
            else{
                moneyDonatedText.text = "-$100,000,000";
            }
        }
    }
    private void moveSliders(){
        if(burnUpgrade2==false){
            BurnSlider.value += Time.deltaTime /2;
        }
        else{
            BurnSlider.value += Time.deltaTime*2;
        }
        if(tipUpgrade2==false){
            TipSlider.value += Time.deltaTime /4;
        }
        else{
            TipSlider.value += Time.deltaTime;
        }
        if(investUpgrade2==false){
            InvestSlider.value += Time.deltaTime / 10;
        }
        else{
            InvestSlider.value += Time.deltaTime / 2.5f;
        }
        if(gambleUpgrade2 == false){
            GambleSlider.value += Time.deltaTime / 20;
        }
        else{
            GambleSlider.value += Time.deltaTime /5;
        }
        if(NFTUpgrade2==false){
            NFTSlider.value += Time.deltaTime / 40;
        }
        else{
            NFTSlider.value += Time.deltaTime / 10;
        }
        if(DonateUpgrade2==false){
            DonateSlider.value += Time.deltaTime / 100;
        }
        else{
            DonateSlider.value += Time.deltaTime /25;
        }
    }
    public void burnMoney(){
        if(BurnSlider.value == 1 && ready){
            money-= moneyBurned;
            BurnSlider.value = 0;
            buySound1.Play();
        }
    }
    public void tipMoney(){
        if(TipSlider.value == 1&& ready){
            money-= moneyTipped;
            TipSlider.value = 0;
            buySound1.Play();
        }
    }
    public void investMoney(){
        if(InvestSlider.value == 1 && ready){
            money-= moneyInvested;
            InvestSlider.value = 0;
            buySound2.Play();
        }
    }
    public void gambleMoney(){
        if(GambleSlider.value == 1 && ready){
            money-= moneyGambled;
            GambleSlider.value = 0;
            buySound2.Play();
        }
    }
    public void buyNFT(){
        if(NFTSlider.value == 1 && ready){
            money-= moneyLostByNFT;
            NFTSlider.value = 0;
            buySound3.Play();
        }
    }
    public void donateMoney(){
        if(DonateSlider.value == 1 && ready){
            money-= moneyDonated;
            DonateSlider.value = 0;
            buySound3.Play();
        }
    }
    public void burnUpgrade1Fun(){
        if(burnUpgrade1==false && ready){
            money -= 1000;
            burnUpgrade1 = true;
            burnUpgrade1Text.text = "Bought";
            moneyBurned *= 100;
            upgradeSound.Play();
        }
    }
    public void burnUpgrade2Fun(){
        if(burnUpgrade2==false && ready){
            money -= 1000;
            burnUpgrade2 = true;
            burnUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    public void tipUpgrade1Fun(){
        if(tipUpgrade1==false && ready){
            money -= 10000;
            tipUpgrade1 = true;
            tipUpgrade1Text.text = "Bought";
            moneyTipped *= 100;
            upgradeSound.Play();
        }
    }
    public void tipUpgrade2Fun(){
        if(tipUpgrade2==false && ready){
            money -= 10000;
            tipUpgrade2 = true;
            tipUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    public void investUpgrade1Fun(){
        if(investUpgrade1==false && ready){
            money -= 100000;
            investUpgrade1 = true;
            investUpgrade1Text.text = "Bought";
            moneyInvested *= 100;
            upgradeSound.Play();
        }
    }
    public void investUpgrade2Fun(){
        if(investUpgrade2==false && ready){
            money -= 100000;
            investUpgrade2 = true;
            investUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    public void gambleUpgrade1Fun(){
        if(gambleUpgrade1==false && ready){
            money -= 1000000;
            gambleUpgrade1 = true;
            gambleUpgrade1Text.text = "Bought";
            moneyGambled *= 100;
            upgradeSound.Play();
        }
    }
    public void gambleUpgrade2Fun(){
        if(gambleUpgrade2==false && ready){
            money -= 1000000;
            gambleUpgrade2 = true;
            gambleUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    public void NFTUpgrade1Fun(){
        if(NFTUpgrade1 == false && ready){
            money -= 10000000;
            NFTUpgrade1 = true;
            NFTUpgrade1Text.text = "Bought";
            moneyLostByNFT *= 100;
            upgradeSound.Play();
        }
    }
    public void NFTUpgrade2Fun(){
        if(NFTUpgrade2 == false && ready){
            money -= 10000000;
            NFTUpgrade2 = true;
            NFTUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    public void DonateUpgrade1Fun(){
        if(DonateUpgrade1==false && ready){
            money -= 100000000;
            DonateUpgrade1 = true;
            DonateUpgrade1Text.text = "Bought";
            moneyDonated *= 100;
            upgradeSound.Play();
        }
    }
    public void DonateUpgrade2Fun(){
        if(DonateUpgrade2==false && ready){
            money -= 100000000;
            DonateUpgrade2 = true;
            DonateUpgrade2Text.text = "Bought";
            upgradeSound.Play();
        }
    }
    
}
