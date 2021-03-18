using UnityEngine;

public class BulletSwitching : MonoBehaviour {
    public int selectedBullet = 0 ;

	void Start () {
        SelectBullet();
	}
	
	void Update () {
        int preSelectedBullet = selectedBullet;
		if(Input.GetButtonUp("Fire2"))
        {
            if (selectedBullet > transform.childCount-2)
                selectedBullet = 0;
            else
                selectedBullet++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedBullet = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedBullet = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedBullet = 2;
        }
        if (preSelectedBullet != selectedBullet)
        {
            SelectBullet();
        }

    }
    void SelectBullet()
    {
        int i = 0;
        foreach(Transform bullet in transform)
        {
            if (i == selectedBullet)
                bullet.gameObject.SetActive(true);
            else
                bullet.gameObject.SetActive(false);
            i++;
        }

    }
}
