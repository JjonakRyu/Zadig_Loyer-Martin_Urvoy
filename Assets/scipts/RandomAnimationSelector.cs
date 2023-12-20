using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationSelector : MonoBehaviour

{
    public KeyCode key1;
    public GameObject[] elements; // Array containing your 17 elements

    void Update()
    { 
        if (Input.GetKeyDown(key1))

        {
            // Call a function to select 13 random elements
            List<GameObject> selectedElements = SelectRandomElements(elements, 13);

            // Trigger the animation for the selected elements
            foreach (GameObject element in selectedElements)
            {
                PlayAnimation(element);
            }
        }

        // Function to select a random subset of elements
        List<T> SelectRandomElements<T>(T[] array, int count)
        {
            List<T> resultList = new List<T>();

            // Shuffle the array to get a random order of elements
            List<T> shuffledList = new List<T>(array);
            for (int i = 0; i < shuffledList.Count; i++)
            {
                T temp = shuffledList[i];
                int randomIndex = Random.Range(i, shuffledList.Count);
                shuffledList[i] = shuffledList[randomIndex];
                shuffledList[randomIndex] = temp;
            }

            // Select the first 'count' elements from the shuffled list
            for (int i = 0; i < count; i++)
            {
                resultList.Add(shuffledList[i]);
            }

            return resultList;
        }

        // Function to play the animation for the selected element
        void PlayAnimation(GameObject element)
        {
            // Assuming you have an Animator component attached to each element
            Animator elementAnimator = element.GetComponent<Animator>();
            if (elementAnimator != null)
            {
                // Trigger the animation using the Animator component
                elementAnimator.SetTrigger("Fall"); // Replace "YourAnimationTrigger" with the trigger name in your Animator Controller
            }
            else
            {
                Debug.LogWarning("Animator component not found on the selected element: " + element.name);
            }
        }
    }
}
