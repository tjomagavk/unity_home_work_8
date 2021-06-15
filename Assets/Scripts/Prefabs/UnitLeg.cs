using System;
using UnityEngine;

namespace Prefabs
{
    public class UnitLeg : MonoBehaviour
    {
        public float currentX;
        private bool _positive;
        private bool _play = true;

        private int _speed = 200;

        public void SetPositive(bool positive)
        {
            _positive = positive;
        }

        public void SetSpeed(int speed)
        {
            _speed = speed;
            currentX = 0;
        }

        public void Stop()
        {
            _play = false;
            currentX = 0;
            rotate(currentX);
        }

        private void Update()
        {
            if (_play)
            {
                Steps();
            }
        }

        private void Steps()
        {
            if (currentX >= 45)
            {
                _positive = false;
            }

            if (currentX <= -45)
            {
                _positive = true;
            }

            if (_positive)
            {
                currentX += Time.deltaTime * _speed;
            }
            else
            {
                currentX -= Time.deltaTime * _speed;
            }

            rotate(currentX);
        }

        private void rotate(float x)
        {
            Vector3 vector3 = new Vector3(x, 0, 0);
            transform.localRotation = Quaternion.Euler(vector3);
        }
    }
}