using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static AudioClip _audioCoin, _audioPulo, _audioMovimentation, _audioMachucar, _audioPonteCaindo, _audioIn, _audioOut;
    public static AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioCoin = Resources.Load<AudioClip>("MOEDAS_01");
        _audioPulo = Resources.Load<AudioClip>("PULO_01");
        _audioMachucar = Resources.Load<AudioClip>("MACHUCAR_01");
        _audioMovimentation = Resources.Load<AudioClip>("PASSOS_01");
        _audioPonteCaindo = Resources.Load<AudioClip>("PONTE_DESMORONANDO_01");
        _audioIn = Resources.Load<AudioClip>("MENSAGEM_IN_01");
        _audioOut = Resources.Load<AudioClip>("MENSAGEM_OUT_01");
    }

    public static void playSound (string som)
    {
        switch (som)
        {
            case "coin1":
                _audioSource.PlayOneShot(_audioCoin);
                _audioSource.volume = 0.3f;
                break;
            case "pulo1":
                _audioSource.PlayOneShot(_audioPulo);
                break;
            case "machucar1":
                _audioSource.PlayOneShot(_audioMachucar);
                break;
            case "steps1":
                _audioSource.PlayOneShot(_audioMovimentation);
                _audioSource.volume = 1f;
                break;
            case "PONTE":
                _audioSource.PlayOneShot(_audioPonteCaindo);
                _audioSource.volume = 0.2f;
                break;
            case "open":
                _audioSource.PlayOneShot(_audioIn);
                _audioSource.volume = 1f;
                break;
            case "close":
                _audioSource.PlayOneShot(_audioOut);
                _audioSource.volume = 1f;
                break;
        }
    }


    // public static void comprasShein(string roupa)
    // {
    //     switch (roupa)
    //     {
    //         case "vestido": print("Tais");
    //             break;
    //         case "jeans": print("Ana Sofia");
    //             break;
    //         case "short": print("Ana julia");
    //             break;
    //         default: print("Hanani");
    //             break;
    //     }
    // }

    // bool somosBonitas()
    // {
    //     return true;
    // }

    // void elogio()
    // {
    //     printf("SOMOS GOSTOSAS");
    // }

    // int idadeAnaSofia()
    // {
    //     return 85;
    // }
}
