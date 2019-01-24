using System.Linq;
using UnityEngine;

namespace AI
{
    public class AISpawner : MonoBehaviour
    {
        public int MinAgents;
        public int MaxAgents;

        public Transform AgentContainer;
        public AIAgent AgentPrefab;
        public ActiveSpots SpawnPoints;
        public ActiveSpots NavigationPoints;

        void Start()
        {
            var availableSpawnpoints = SpawnPoints.GetSpots.ToList();
            foreach (var _ in Enumerable.Range(0, Random.Range(MinAgents, MaxAgents + 1)))
            {
                var agent = Instantiate(AgentPrefab, AgentContainer);
                var spawnPoint = availableSpawnpoints.PickOne();
                agent.transform.position = spawnPoint.position;
                availableSpawnpoints.Remove(spawnPoint);
                agent.Initialize(NavigationPoints);
            }
        }
    }
}
