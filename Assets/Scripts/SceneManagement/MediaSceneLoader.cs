using UnityEngine;

/// <summary>
/// This class relegates signals dispatched from the camera flythrough timeline
/// </summary>
public class MediaSceneLoader : MonoBehaviour
{
    [SerializeField] private SceneLoader m_GardenSceneLoader;
    [SerializeField] private SceneLoader m_CockpitSceneLoader;
    
    private SceneLoader HubSceneLoader;

    void Start()
    {
        HubSceneLoader = GetComponent<SceneLoader>();
    }
    public void EnableGarden()
    {
        m_GardenSceneLoader.EnableScene();
    }

    public void DisableGarden()
    {
        m_GardenSceneLoader.DisableScene();
    }

    public void EnableCockpit()
    {
        m_CockpitSceneLoader.EnableScene();
    }

    public void DisableCockpit()
    {
        m_CockpitSceneLoader.DisableScene();
    }

    public void EnableHub()
    {
        HubSceneLoader.EnableScene();
    }


    public void Transition()
    {
        SceneTransitionManager.StartTransition(this);
    }

    public SceneLoader GetHubSceneLoader()
    {
        return HubSceneLoader;
    }
    
}
