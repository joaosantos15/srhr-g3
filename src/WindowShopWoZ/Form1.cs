using EmoteCommonMessages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thalamus;

namespace WindowShopWoZ
{
    public interface IWindowShopPublisher : IThalamusPublisher, IFMLSpeech, Thalamus.BML.IAnimationActions { }

    public partial class Form1 : Form
    {
        private class WindowShopWoZ : ThalamusClient
        {
            private class WindowShopPublisher : IWindowShopPublisher
            {
                dynamic publisher;
                public WindowShopPublisher(dynamic publisher)
                {
                    this.publisher = publisher;
                }

                public void CancelUtterance(string id)
                {
                    throw new NotImplementedException();
                }

                public void PerformUtterance(string id, string utterance, string category)
                {
                    this.publisher.PerformUtterance(id, utterance, category);
                }

                public void PerformUtteranceFromLibrary(string id, string category, string subcategory, string[] tagNames, string[] tagValues)
                {
                    this.publisher.PerformUtterance(id, category, subcategory, tagNames, tagValues);
                }

                public void PerformUtteranceWithTags(string id, string utterance, string[] tagNames, string[] tagValues)
                {
                    this.publisher.PerformUtterance(id, utterance, tagNames, tagValues);
                }

                public void PlayAnimation(string id, string animation)
                {
                    this.publisher.PlayAnimation(id, animation);
                }

                public void PlayAnimationQueued(string id, string animation)
                {
                    throw new NotImplementedException();
                }

                public void StopAnimation(string id)
                {
                    throw new NotImplementedException();
                }
            }

            private WindowShopPublisher wsPublisher;

            public WindowShopWoZ()
                : base("WindowShopWoZ", "")
            {

                SetPublisher<IWindowShopPublisher>();
                wsPublisher = new WindowShopPublisher(Publisher);
            }

            public void PeopleEntering()
            {
                wsPublisher.PlayAnimation("", "greeting");
            }

            public void PeopleLeaving()
            {
                wsPublisher.PlayAnimation("", "goodbye");
            }

            public void Thinking()
            {
                wsPublisher.PlayAnimation("", "rodinThinking");

            }

            public void Sadness()
            {
                wsPublisher.PlayAnimation("", "sadnessNodding");
            }

            public void Reach()
            {
                wsPublisher.PlayAnimation("", "enthusiasm");
            }

            public void Happiness()
            {
                wsPublisher.PlayAnimation("", "happy");
            }

            public void Idle()
            {
                wsPublisher.PlayAnimation("", "endPose");
            }

            public void PointLeft()
            {
                wsPublisher.PlayAnimation("", "PointPlayerLeft");
            }

            public void PointRight()
            {
                wsPublisher.PlayAnimation("", "PointPlayerRight");
            }
        }

        private WindowShopWoZ WoZ;

        public Form1()
        {
            InitializeComponent();
            WoZ = new WindowShopWoZ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WoZ.PeopleEntering();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WoZ.PeopleLeaving();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WoZ.Dispose();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            WoZ.Thinking();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WoZ.Sadness();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WoZ.Reach();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WoZ.Happiness();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WoZ.Idle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WoZ.PointLeft();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WoZ.PointRight();
        }
    }
}
