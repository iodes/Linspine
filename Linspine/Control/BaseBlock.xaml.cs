using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Linspine.Control
{
    /// <summary>
    /// BaseBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BaseBlock : UserControl
    {
        #region 속성
        //TODO 의존성 속성 작성 필요
        //TODO 스택 패널 바인딩 작성 필요

        public Brush BlockBorder { get; set; }

        public Thickness BlockBorderThickness { get; set; }

        public CornerRadius BlockCornerRadius { get; set; }

        public Brush BlockBackground { get; set; }
        #endregion

        #region 생성자
        public BaseBlock()
        {
            InitializeComponent();
            DataContext = this;
        }
        #endregion
    }
}
