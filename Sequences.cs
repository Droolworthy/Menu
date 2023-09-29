using UnityEngine;
using DG.Tweening;

public class Sequences : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _durationMove;
    [SerializeField] private float _durationRotate;
    [SerializeField] private float _scale;
    [SerializeField] private float _durationScale;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();       

        sequence.Append(transform.DOMove(_targetPosition, _durationMove));
        sequence.Append(transform.DOScale(_scale, _durationScale));
        sequence.Append(transform.DORotate(_rotate, _durationRotate));
    }
}
