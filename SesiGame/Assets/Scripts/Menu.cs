using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        //ativa painel do menu
        menuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //funçao do botão start 
    public void StartGame()
    {
        //carrega a cena do game
        SceneManager.LoadScene(nomeCena);
    }
    //função do botão sair
    public void QuitGame()
    {
        //jogo rodando na unity
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
