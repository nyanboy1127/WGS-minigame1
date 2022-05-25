using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace RunMinigames.Manager.Networking.PhotonConnection
{
    public class ConnectToServer : MonoBehaviourPunCallbacks
    {
        public InputField usernameInput;
        public TextMeshProUGUI buttonText;

        public void OnClickConnect()
        {
            if (usernameInput.text.Length >= 1)
            {
                PhotonNetwork.NickName = usernameInput.text;
                buttonText.text = "Connecting...";
                PhotonNetwork.AutomaticallySyncScene = true;
                PhotonNetwork.ConnectUsingSettings();
                PlayerPrefs.SetString("PLAYERNICKNAME", PhotonNetwork.NickName);
            }
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("Connected to master");
            SceneManager.LoadScene("WGS3_Lobby");
        }

        public override void OnConnected()
        {
            base.OnConnected();
            Debug.Log("Connected");
        }
    }
}

