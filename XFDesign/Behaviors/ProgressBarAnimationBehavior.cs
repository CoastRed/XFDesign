using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace XFDesign.Behaviors
{
    /// <summary>
    /// 进度条动画
    /// </summary>
    public class ProgressBarAnimationBehavior:Behavior<ProgressBar>
    {
        private bool IsRun { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.ValueChanged += AssociatedObject_ValueChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.ValueChanged -= AssociatedObject_ValueChanged;
        }

        private void AssociatedObject_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.IsRun) return;
            this.IsRun = true;
            ProgressBar? progressBar = sender as ProgressBar;
            if (progressBar == null)
            {
                return;
            }
            DoubleAnimation animation = new DoubleAnimation(e.OldValue, e.NewValue, new System.Windows.Duration(TimeSpan.FromSeconds(0.3)), FillBehavior.Stop);
            animation.Completed += Animation_Completed;
            progressBar.BeginAnimation(ProgressBar.ValueProperty, animation);

        }

        private void Animation_Completed(object? sender, EventArgs e)
        {
            this.IsRun = false;
        }
    }
}
