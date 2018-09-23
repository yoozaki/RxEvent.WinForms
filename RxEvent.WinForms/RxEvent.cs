
using System.Reactive.Linq;
 
 
namespace System.ComponentModel
{
     
    public static class ComponentEventExtensions
    {
         
        public static IObservable<System.EventArgs> DisposedAsObservable(this Component source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Disposed += h,
                h => source.Disposed -= h);
        }
            }
    }
 
namespace System.Windows.Forms
{
     
    public static class AxHostEventExtensions
    {
         
        public static IObservable<System.EventArgs> MouseClickAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.EventArgs> MouseDoubleClickAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BindingContextChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BindingContextChanged += h,
                h => source.BindingContextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuChanged += h,
                h => source.ContextMenuChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragDropAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragDrop += h,
                h => source.DragDrop -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragEnterAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragEnter += h,
                h => source.DragEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragOverAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragOver += h,
                h => source.DragOver -= h);
        }
         
        public static IObservable<System.EventArgs> DragLeaveAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DragLeave += h,
                h => source.DragLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.Windows.Forms.HelpEventArgs> HelpRequestedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.HelpEventHandler, System.Windows.Forms.HelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequested += h,
                h => source.HelpRequested -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryContinueDragEventArgs> QueryContinueDragAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryContinueDragEventHandler, System.Windows.Forms.QueryContinueDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryContinueDrag += h,
                h => source.QueryContinueDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryAccessibilityHelpEventHandler, System.Windows.Forms.QueryAccessibilityHelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryAccessibilityHelp += h,
                h => source.QueryAccessibilityHelp -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.LayoutEventArgs> LayoutAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.LayoutEventHandler, System.Windows.Forms.LayoutEventArgs>(
                h => (sender, args) => h(args),
                h => source.Layout += h,
                h => source.Layout -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.EventArgs> MouseHoverAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseHover += h,
                h => source.MouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseWheelAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseWheel += h,
                h => source.MouseWheel -= h);
        }
         
        public static IObservable<System.Windows.Forms.UICuesEventArgs> ChangeUICuesAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.UICuesEventHandler, System.Windows.Forms.UICuesEventArgs>(
                h => (sender, args) => h(args),
                h => source.ChangeUICues += h,
                h => source.ChangeUICues -= h);
        }
         
        public static IObservable<System.EventArgs> StyleChangedAsObservable(this AxHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StyleChanged += h,
                h => source.StyleChanged -= h);
        }
            }
     
    public static class ControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BindingContextChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BindingContextChanged += h,
                h => source.BindingContextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClientSizeChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ClientSizeChanged += h,
                h => source.ClientSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuChanged += h,
                h => source.ContextMenuChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuStripChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuStripChanged += h,
                h => source.ContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MarginChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MarginChanged += h,
                h => source.MarginChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RegionChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RegionChanged += h,
                h => source.RegionChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SizeChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SizeChanged += h,
                h => source.SizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VisibleChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VisibleChanged += h,
                h => source.VisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlAddedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlAdded += h,
                h => source.ControlAdded -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlRemovedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlRemoved += h,
                h => source.ControlRemoved -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragDropAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragDrop += h,
                h => source.DragDrop -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragEnterAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragEnter += h,
                h => source.DragEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragOverAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragOver += h,
                h => source.DragOver -= h);
        }
         
        public static IObservable<System.EventArgs> DragLeaveAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DragLeave += h,
                h => source.DragLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.EventArgs> HandleCreatedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HandleCreated += h,
                h => source.HandleCreated -= h);
        }
         
        public static IObservable<System.EventArgs> HandleDestroyedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HandleDestroyed += h,
                h => source.HandleDestroyed -= h);
        }
         
        public static IObservable<System.Windows.Forms.HelpEventArgs> HelpRequestedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.HelpEventHandler, System.Windows.Forms.HelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequested += h,
                h => source.HelpRequested -= h);
        }
         
        public static IObservable<System.Windows.Forms.InvalidateEventArgs> InvalidatedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.InvalidateEventHandler, System.Windows.Forms.InvalidateEventArgs>(
                h => (sender, args) => h(args),
                h => source.Invalidated += h,
                h => source.Invalidated -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryContinueDragEventArgs> QueryContinueDragAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryContinueDragEventHandler, System.Windows.Forms.QueryContinueDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryContinueDrag += h,
                h => source.QueryContinueDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryAccessibilityHelpEventHandler, System.Windows.Forms.QueryAccessibilityHelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryAccessibilityHelp += h,
                h => source.QueryAccessibilityHelp -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.EventArgs> GotFocusAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.GotFocus += h,
                h => source.GotFocus -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.LayoutEventArgs> LayoutAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.LayoutEventHandler, System.Windows.Forms.LayoutEventArgs>(
                h => (sender, args) => h(args),
                h => source.Layout += h,
                h => source.Layout -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.EventArgs> LostFocusAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LostFocus += h,
                h => source.LostFocus -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> MouseCaptureChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseCaptureChanged += h,
                h => source.MouseCaptureChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.EventArgs> DpiChangedBeforeParentAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DpiChangedBeforeParent += h,
                h => source.DpiChangedBeforeParent -= h);
        }
         
        public static IObservable<System.EventArgs> DpiChangedAfterParentAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DpiChangedAfterParent += h,
                h => source.DpiChangedAfterParent -= h);
        }
         
        public static IObservable<System.EventArgs> MouseHoverAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseHover += h,
                h => source.MouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseWheelAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseWheel += h,
                h => source.MouseWheel -= h);
        }
         
        public static IObservable<System.EventArgs> MoveAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Move += h,
                h => source.Move -= h);
        }
         
        public static IObservable<System.Windows.Forms.PreviewKeyDownEventArgs> PreviewKeyDownAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.PreviewKeyDownEventHandler, System.Windows.Forms.PreviewKeyDownEventArgs>(
                h => (sender, args) => h(args),
                h => source.PreviewKeyDown += h,
                h => source.PreviewKeyDown -= h);
        }
         
        public static IObservable<System.EventArgs> ResizeAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Resize += h,
                h => source.Resize -= h);
        }
         
        public static IObservable<System.Windows.Forms.UICuesEventArgs> ChangeUICuesAsObservable(this Control source)
        {
            return Observable.FromEvent<System.Windows.Forms.UICuesEventHandler, System.Windows.Forms.UICuesEventArgs>(
                h => (sender, args) => h(args),
                h => source.ChangeUICues += h,
                h => source.ChangeUICues -= h);
        }
         
        public static IObservable<System.EventArgs> StyleChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StyleChanged += h,
                h => source.StyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SystemColorsChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SystemColorsChanged += h,
                h => source.SystemColorsChanged -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> ValidatingAsObservable(this Control source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Validating += h,
                h => source.Validating -= h);
        }
         
        public static IObservable<System.EventArgs> ValidatedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Validated += h,
                h => source.Validated -= h);
        }
         
        public static IObservable<System.EventArgs> ParentChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ParentChanged += h,
                h => source.ParentChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this Control source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
            }
     
    public static class BindingNavigatorEventExtensions
    {
         
        public static IObservable<System.EventArgs> RefreshItemsAsObservable(this BindingNavigator source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RefreshItems += h,
                h => source.RefreshItems -= h);
        }
            }
     
    public static class ToolStripEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BeginDragAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BeginDrag += h,
                h => source.BeginDrag -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlAddedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlAdded += h,
                h => source.ControlAdded -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlRemovedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlRemoved += h,
                h => source.ControlRemoved -= h);
        }
         
        public static IObservable<System.EventArgs> EndDragAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EndDrag += h,
                h => source.EndDrag -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripItemEventArgs> ItemAddedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripItemEventHandler, System.Windows.Forms.ToolStripItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemAdded += h,
                h => source.ItemAdded -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripItemClickedEventArgs> ItemClickedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripItemClickedEventHandler, System.Windows.Forms.ToolStripItemClickedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemClicked += h,
                h => source.ItemClicked -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripItemEventArgs> ItemRemovedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripItemEventHandler, System.Windows.Forms.ToolStripItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemRemoved += h,
                h => source.ItemRemoved -= h);
        }
         
        public static IObservable<System.EventArgs> LayoutCompletedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LayoutCompleted += h,
                h => source.LayoutCompleted -= h);
        }
         
        public static IObservable<System.EventArgs> LayoutStyleChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LayoutStyleChanged += h,
                h => source.LayoutStyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintGripAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.PaintGrip += h,
                h => source.PaintGrip -= h);
        }
         
        public static IObservable<System.EventArgs> RendererChangedAsObservable(this ToolStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RendererChanged += h,
                h => source.RendererChanged -= h);
        }
            }
     
    public static class ScrollableControlEventExtensions
    {
         
        public static IObservable<System.Windows.Forms.ScrollEventArgs> ScrollAsObservable(this ScrollableControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.ScrollEventHandler, System.Windows.Forms.ScrollEventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
            }
     
    public static class BindingSourceEventExtensions
    {
         
        public static IObservable<System.ComponentModel.AddingNewEventArgs> AddingNewAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.ComponentModel.AddingNewEventHandler, System.ComponentModel.AddingNewEventArgs>(
                h => (sender, args) => h(args),
                h => source.AddingNew += h,
                h => source.AddingNew -= h);
        }
         
        public static IObservable<System.Windows.Forms.BindingCompleteEventArgs> BindingCompleteAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.Windows.Forms.BindingCompleteEventHandler, System.Windows.Forms.BindingCompleteEventArgs>(
                h => (sender, args) => h(args),
                h => source.BindingComplete += h,
                h => source.BindingComplete -= h);
        }
         
        public static IObservable<System.Windows.Forms.BindingManagerDataErrorEventArgs> DataErrorAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.Windows.Forms.BindingManagerDataErrorEventHandler, System.Windows.Forms.BindingManagerDataErrorEventArgs>(
                h => (sender, args) => h(args),
                h => source.DataError += h,
                h => source.DataError -= h);
        }
         
        public static IObservable<System.EventArgs> DataSourceChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataSourceChanged += h,
                h => source.DataSourceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DataMemberChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataMemberChanged += h,
                h => source.DataMemberChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CurrentChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CurrentChanged += h,
                h => source.CurrentChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CurrentItemChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CurrentItemChanged += h,
                h => source.CurrentItemChanged -= h);
        }
         
        public static IObservable<System.ComponentModel.ListChangedEventArgs> ListChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.ComponentModel.ListChangedEventHandler, System.ComponentModel.ListChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ListChanged += h,
                h => source.ListChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PositionChangedAsObservable(this BindingSource source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PositionChanged += h,
                h => source.PositionChanged -= h);
        }
            }
     
    public static class ButtonEventExtensions
    {
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this Button source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this Button source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
            }
     
    public static class ButtonBaseEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ButtonBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this ButtonBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
            }
     
    public static class CheckBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> AppearanceChangedAsObservable(this CheckBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AppearanceChanged += h,
                h => source.AppearanceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this CheckBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this CheckBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> CheckedChangedAsObservable(this CheckBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckedChanged += h,
                h => source.CheckedChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CheckStateChangedAsObservable(this CheckBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckStateChanged += h,
                h => source.CheckStateChanged -= h);
        }
            }
     
    public static class CheckedListBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> DataSourceChangedAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataSourceChanged += h,
                h => source.DataSourceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DisplayMemberChangedAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DisplayMemberChanged += h,
                h => source.DisplayMemberChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ItemCheckEventArgs> ItemCheckAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.ItemCheckEventHandler, System.Windows.Forms.ItemCheckEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemCheck += h,
                h => source.ItemCheck -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawItemEventArgs> DrawItemAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawItemEventHandler, System.Windows.Forms.DrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.MeasureItemEventArgs> MeasureItemAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MeasureItemEventHandler, System.Windows.Forms.MeasureItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.MeasureItem += h,
                h => source.MeasureItem -= h);
        }
         
        public static IObservable<System.EventArgs> ValueMemberChangedAsObservable(this CheckedListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueMemberChanged += h,
                h => source.ValueMemberChanged -= h);
        }
            }
     
    public static class ListBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawItemEventArgs> DrawItemAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawItemEventHandler, System.Windows.Forms.DrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.MeasureItemEventArgs> MeasureItemAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MeasureItemEventHandler, System.Windows.Forms.MeasureItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.MeasureItem += h,
                h => source.MeasureItem -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedIndexChangedAsObservable(this ListBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedIndexChanged += h,
                h => source.SelectedIndexChanged -= h);
        }
            }
     
    public static class ListControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> DataSourceChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataSourceChanged += h,
                h => source.DataSourceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DisplayMemberChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DisplayMemberChanged += h,
                h => source.DisplayMemberChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ListControlConvertEventArgs> FormatAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.ListControlConvertEventHandler, System.Windows.Forms.ListControlConvertEventArgs>(
                h => (sender, args) => h(args),
                h => source.Format += h,
                h => source.Format -= h);
        }
         
        public static IObservable<System.EventArgs> FormatInfoChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FormatInfoChanged += h,
                h => source.FormatInfoChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FormatStringChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FormatStringChanged += h,
                h => source.FormatStringChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FormattingEnabledChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FormattingEnabledChanged += h,
                h => source.FormattingEnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ValueMemberChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueMemberChanged += h,
                h => source.ValueMemberChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedValueChangedAsObservable(this ListControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedValueChanged += h,
                h => source.SelectedValueChanged -= h);
        }
            }
     
    public static class CommonDialogEventExtensions
    {
         
        public static IObservable<System.EventArgs> HelpRequestAsObservable(this CommonDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequest += h,
                h => source.HelpRequest -= h);
        }
            }
     
    public static class ComboBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawItemEventArgs> DrawItemAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawItemEventHandler, System.Windows.Forms.DrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDown += h,
                h => source.DropDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.MeasureItemEventArgs> MeasureItemAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MeasureItemEventHandler, System.Windows.Forms.MeasureItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.MeasureItem += h,
                h => source.MeasureItem -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedIndexChangedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedIndexChanged += h,
                h => source.SelectedIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectionChangeCommittedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectionChangeCommitted += h,
                h => source.SelectionChangeCommitted -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownStyleChangedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownStyleChanged += h,
                h => source.DropDownStyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.EventArgs> TextUpdateAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextUpdate += h,
                h => source.TextUpdate -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownClosedAsObservable(this ComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownClosed += h,
                h => source.DropDownClosed -= h);
        }
            }
     
    public static class ContainerControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoValidateChangedAsObservable(this ContainerControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoValidateChanged += h,
                h => source.AutoValidateChanged -= h);
        }
            }
     
    public static class ContextMenuEventExtensions
    {
         
        public static IObservable<System.EventArgs> PopupAsObservable(this ContextMenu source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Popup += h,
                h => source.Popup -= h);
        }
         
        public static IObservable<System.EventArgs> CollapseAsObservable(this ContextMenu source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Collapse += h,
                h => source.Collapse -= h);
        }
            }
     
    public static class ToolStripDropDownEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BindingContextChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BindingContextChanged += h,
                h => source.BindingContextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.UICuesEventArgs> ChangeUICuesAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.UICuesEventHandler, System.Windows.Forms.UICuesEventArgs>(
                h => (sender, args) => h(args),
                h => source.ChangeUICues += h,
                h => source.ChangeUICues -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuChanged += h,
                h => source.ContextMenuChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuStripChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuStripChanged += h,
                h => source.ContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripDropDownClosedEventArgs> ClosedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripDropDownClosedEventHandler, System.Windows.Forms.ToolStripDropDownClosedEventArgs>(
                h => (sender, args) => h(args),
                h => source.Closed += h,
                h => source.Closed -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripDropDownClosingEventArgs> ClosingAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripDropDownClosingEventHandler, System.Windows.Forms.ToolStripDropDownClosingEventArgs>(
                h => (sender, args) => h(args),
                h => source.Closing += h,
                h => source.Closing -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.Windows.Forms.HelpEventArgs> HelpRequestedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.HelpEventHandler, System.Windows.Forms.HelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequested += h,
                h => source.HelpRequested -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> OpeningAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Opening += h,
                h => source.Opening -= h);
        }
         
        public static IObservable<System.EventArgs> OpenedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Opened += h,
                h => source.Opened -= h);
        }
         
        public static IObservable<System.EventArgs> RegionChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RegionChanged += h,
                h => source.RegionChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ScrollEventArgs> ScrollAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.Windows.Forms.ScrollEventHandler, System.Windows.Forms.ScrollEventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
         
        public static IObservable<System.EventArgs> StyleChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StyleChanged += h,
                h => source.StyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ValidatedAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Validated += h,
                h => source.Validated -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> ValidatingAsObservable(this ToolStripDropDown source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Validating += h,
                h => source.Validating -= h);
        }
            }
     
    public static class DataGridEventExtensions
    {
         
        public static IObservable<System.EventArgs> BorderStyleChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BorderStyleChanged += h,
                h => source.BorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CaptionVisibleChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CaptionVisibleChanged += h,
                h => source.CaptionVisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CurrentCellChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CurrentCellChanged += h,
                h => source.CurrentCellChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DataSourceChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataSourceChanged += h,
                h => source.DataSourceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ParentRowsLabelStyleChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ParentRowsLabelStyleChanged += h,
                h => source.ParentRowsLabelStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FlatModeChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FlatModeChanged += h,
                h => source.FlatModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundColorChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundColorChanged += h,
                h => source.BackgroundColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowNavigationChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowNavigationChanged += h,
                h => source.AllowNavigationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ParentRowsVisibleChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ParentRowsVisibleChanged += h,
                h => source.ParentRowsVisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.NavigateEventArgs> NavigateAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.NavigateEventHandler, System.Windows.Forms.NavigateEventArgs>(
                h => (sender, args) => h(args),
                h => source.Navigate += h,
                h => source.Navigate -= h);
        }
         
        public static IObservable<System.EventArgs> ScrollAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
         
        public static IObservable<System.EventArgs> BackButtonClickAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackButtonClick += h,
                h => source.BackButtonClick -= h);
        }
         
        public static IObservable<System.EventArgs> ShowParentDetailsButtonClickAsObservable(this DataGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ShowParentDetailsButtonClick += h,
                h => source.ShowParentDetailsButtonClick -= h);
        }
            }
     
    public static class DataGridBoolColumnEventExtensions
    {
         
        public static IObservable<System.EventArgs> TrueValueChangedAsObservable(this DataGridBoolColumn source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TrueValueChanged += h,
                h => source.TrueValueChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FalseValueChangedAsObservable(this DataGridBoolColumn source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FalseValueChanged += h,
                h => source.FalseValueChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowNullChangedAsObservable(this DataGridBoolColumn source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowNullChanged += h,
                h => source.AllowNullChanged -= h);
        }
            }
     
    public static class DataGridColumnStyleEventExtensions
    {
         
        public static IObservable<System.EventArgs> AlignmentChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AlignmentChanged += h,
                h => source.AlignmentChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PropertyDescriptorChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PropertyDescriptorChanged += h,
                h => source.PropertyDescriptorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> HeaderTextChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HeaderTextChanged += h,
                h => source.HeaderTextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MappingNameChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MappingNameChanged += h,
                h => source.MappingNameChanged -= h);
        }
         
        public static IObservable<System.EventArgs> NullTextChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.NullTextChanged += h,
                h => source.NullTextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
         
        public static IObservable<System.EventArgs> WidthChangedAsObservable(this DataGridColumnStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.WidthChanged += h,
                h => source.WidthChanged -= h);
        }
            }
     
    public static class DataGridTableStyleEventExtensions
    {
         
        public static IObservable<System.EventArgs> AllowSortingChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowSortingChanged += h,
                h => source.AllowSortingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AlternatingBackColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AlternatingBackColorChanged += h,
                h => source.AlternatingBackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> GridLineColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.GridLineColorChanged += h,
                h => source.GridLineColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> GridLineStyleChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.GridLineStyleChanged += h,
                h => source.GridLineStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> HeaderBackColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HeaderBackColorChanged += h,
                h => source.HeaderBackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> HeaderFontChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HeaderFontChanged += h,
                h => source.HeaderFontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> HeaderForeColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HeaderForeColorChanged += h,
                h => source.HeaderForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LinkColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LinkColorChanged += h,
                h => source.LinkColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LinkHoverColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LinkHoverColorChanged += h,
                h => source.LinkHoverColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PreferredColumnWidthChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PreferredColumnWidthChanged += h,
                h => source.PreferredColumnWidthChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PreferredRowHeightChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PreferredRowHeightChanged += h,
                h => source.PreferredRowHeightChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ColumnHeadersVisibleChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeadersVisibleChanged += h,
                h => source.ColumnHeadersVisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowHeadersVisibleChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeadersVisibleChanged += h,
                h => source.RowHeadersVisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowHeaderWidthChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeaderWidthChanged += h,
                h => source.RowHeaderWidthChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectionBackColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectionBackColorChanged += h,
                h => source.SelectionBackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectionForeColorChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectionForeColorChanged += h,
                h => source.SelectionForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MappingNameChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MappingNameChanged += h,
                h => source.MappingNameChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this DataGridTableStyle source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
            }
     
    public static class TextBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> TextAlignChangedAsObservable(this TextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextAlignChanged += h,
                h => source.TextAlignChanged -= h);
        }
            }
     
    public static class TextBoxBaseEventExtensions
    {
         
        public static IObservable<System.EventArgs> AcceptsTabChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AcceptsTabChanged += h,
                h => source.AcceptsTabChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BorderStyleChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BorderStyleChanged += h,
                h => source.BorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.EventArgs> HideSelectionChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HideSelectionChanged += h,
                h => source.HideSelectionChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ModifiedChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ModifiedChanged += h,
                h => source.ModifiedChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MultilineChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MultilineChanged += h,
                h => source.MultilineChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this TextBoxBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
            }
     
    public static class DataGridViewEventExtensions
    {
         
        public static IObservable<System.EventArgs> AllowUserToAddRowsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowUserToAddRowsChanged += h,
                h => source.AllowUserToAddRowsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowUserToDeleteRowsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowUserToDeleteRowsChanged += h,
                h => source.AllowUserToDeleteRowsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowUserToOrderColumnsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowUserToOrderColumnsChanged += h,
                h => source.AllowUserToOrderColumnsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowUserToResizeColumnsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowUserToResizeColumnsChanged += h,
                h => source.AllowUserToResizeColumnsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AllowUserToResizeRowsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AllowUserToResizeRowsChanged += h,
                h => source.AllowUserToResizeRowsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AlternatingRowsDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AlternatingRowsDefaultCellStyleChanged += h,
                h => source.AlternatingRowsDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AutoGenerateColumnsChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoGenerateColumnsChanged += h,
                h => source.AutoGenerateColumnsChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventArgs> AutoSizeColumnsModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler, System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeColumnsModeChanged += h,
                h => source.AutoSizeColumnsModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewAutoSizeModeEventArgs> AutoSizeRowsModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewAutoSizeModeEventHandler, System.Windows.Forms.DataGridViewAutoSizeModeEventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeRowsModeChanged += h,
                h => source.AutoSizeRowsModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundColorChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundColorChanged += h,
                h => source.BackgroundColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BorderStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BorderStyleChanged += h,
                h => source.BorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CellBorderStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CellBorderStyleChanged += h,
                h => source.CellBorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ColumnHeadersBorderStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeadersBorderStyleChanged += h,
                h => source.ColumnHeadersBorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ColumnHeadersDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeadersDefaultCellStyleChanged += h,
                h => source.ColumnHeadersDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ColumnHeadersHeightChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeadersHeightChanged += h,
                h => source.ColumnHeadersHeightChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewAutoSizeModeEventArgs> ColumnHeadersHeightSizeModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewAutoSizeModeEventHandler, System.Windows.Forms.DataGridViewAutoSizeModeEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeadersHeightSizeModeChanged += h,
                h => source.ColumnHeadersHeightSizeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DataMemberChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataMemberChanged += h,
                h => source.DataMemberChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DataSourceChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DataSourceChanged += h,
                h => source.DataSourceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DefaultCellStyleChanged += h,
                h => source.DefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EditModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EditModeChanged += h,
                h => source.EditModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> GridColorChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.GridColorChanged += h,
                h => source.GridColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MultiSelectChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MultiSelectChanged += h,
                h => source.MultiSelectChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowHeadersBorderStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeadersBorderStyleChanged += h,
                h => source.RowHeadersBorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowHeadersDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeadersDefaultCellStyleChanged += h,
                h => source.RowHeadersDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowHeadersWidthChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeadersWidthChanged += h,
                h => source.RowHeadersWidthChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewAutoSizeModeEventArgs> RowHeadersWidthSizeModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewAutoSizeModeEventHandler, System.Windows.Forms.DataGridViewAutoSizeModeEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeadersWidthSizeModeChanged += h,
                h => source.RowHeadersWidthSizeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RowsDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RowsDefaultCellStyleChanged += h,
                h => source.RowsDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewAutoSizeColumnModeEventArgs> AutoSizeColumnModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler, System.Windows.Forms.DataGridViewAutoSizeColumnModeEventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeColumnModeChanged += h,
                h => source.AutoSizeColumnModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.QuestionEventArgs> CancelRowEditAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.QuestionEventHandler, System.Windows.Forms.QuestionEventArgs>(
                h => (sender, args) => h(args),
                h => source.CancelRowEdit += h,
                h => source.CancelRowEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellCancelEventArgs> CellBeginEditAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellCancelEventHandler, System.Windows.Forms.DataGridViewCellCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellBeginEdit += h,
                h => source.CellBeginEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellClick += h,
                h => source.CellClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellContentClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellContentClick += h,
                h => source.CellContentClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellContentDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellContentDoubleClick += h,
                h => source.CellContentDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellContextMenuStripChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellContextMenuStripChanged += h,
                h => source.CellContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs> CellContextMenuStripNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler, System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellContextMenuStripNeeded += h,
                h => source.CellContextMenuStripNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellDoubleClick += h,
                h => source.CellDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellEndEditAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellEndEdit += h,
                h => source.CellEndEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellEnterAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellEnter += h,
                h => source.CellEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellErrorTextChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellErrorTextChanged += h,
                h => source.CellErrorTextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs> CellErrorTextNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellErrorTextNeededEventHandler, System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellErrorTextNeeded += h,
                h => source.CellErrorTextNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellFormattingEventArgs> CellFormattingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellFormattingEventHandler, System.Windows.Forms.DataGridViewCellFormattingEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellFormatting += h,
                h => source.CellFormatting -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellLeaveAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellLeave += h,
                h => source.CellLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> CellMouseClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseClick += h,
                h => source.CellMouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> CellMouseDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseDoubleClick += h,
                h => source.CellMouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> CellMouseDownAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseDown += h,
                h => source.CellMouseDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellMouseEnterAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseEnter += h,
                h => source.CellMouseEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellMouseLeaveAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseLeave += h,
                h => source.CellMouseLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> CellMouseMoveAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseMove += h,
                h => source.CellMouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> CellMouseUpAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellMouseUp += h,
                h => source.CellMouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellPaintingEventArgs> CellPaintingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellPaintingEventHandler, System.Windows.Forms.DataGridViewCellPaintingEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellPainting += h,
                h => source.CellPainting -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellParsingEventArgs> CellParsingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellParsingEventHandler, System.Windows.Forms.DataGridViewCellParsingEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellParsing += h,
                h => source.CellParsing -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellStateChangedEventArgs> CellStateChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellStateChangedEventHandler, System.Windows.Forms.DataGridViewCellStateChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellStateChanged += h,
                h => source.CellStateChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellStyleChanged += h,
                h => source.CellStyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellStyleContentChangedEventArgs> CellStyleContentChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellStyleContentChangedEventHandler, System.Windows.Forms.DataGridViewCellStyleContentChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellStyleContentChanged += h,
                h => source.CellStyleContentChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellToolTipTextChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellToolTipTextChanged += h,
                h => source.CellToolTipTextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs> CellToolTipTextNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler, System.Windows.Forms.DataGridViewCellToolTipTextNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellToolTipTextNeeded += h,
                h => source.CellToolTipTextNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellValidatedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellValidated += h,
                h => source.CellValidated -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellValidatingEventArgs> CellValidatingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellValidatingEventHandler, System.Windows.Forms.DataGridViewCellValidatingEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellValidating += h,
                h => source.CellValidating -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> CellValueChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellValueChanged += h,
                h => source.CellValueChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellValueEventArgs> CellValueNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellValueEventHandler, System.Windows.Forms.DataGridViewCellValueEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellValueNeeded += h,
                h => source.CellValueNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellValueEventArgs> CellValuePushedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellValueEventHandler, System.Windows.Forms.DataGridViewCellValueEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellValuePushed += h,
                h => source.CellValuePushed -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnAddedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnAdded += h,
                h => source.ColumnAdded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnContextMenuStripChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnContextMenuStripChanged += h,
                h => source.ColumnContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnDataPropertyNameChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnDataPropertyNameChanged += h,
                h => source.ColumnDataPropertyNameChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnDefaultCellStyleChanged += h,
                h => source.ColumnDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnDisplayIndexChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnDisplayIndexChanged += h,
                h => source.ColumnDisplayIndexChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs> ColumnDividerDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventHandler, System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnDividerDoubleClick += h,
                h => source.ColumnDividerDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnDividerWidthChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnDividerWidthChanged += h,
                h => source.ColumnDividerWidthChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> ColumnHeaderMouseClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeaderMouseClick += h,
                h => source.ColumnHeaderMouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> ColumnHeaderMouseDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeaderMouseDoubleClick += h,
                h => source.ColumnHeaderMouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnHeaderCellChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnHeaderCellChanged += h,
                h => source.ColumnHeaderCellChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnMinimumWidthChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnMinimumWidthChanged += h,
                h => source.ColumnMinimumWidthChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnNameChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnNameChanged += h,
                h => source.ColumnNameChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnRemovedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnRemoved += h,
                h => source.ColumnRemoved -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnSortModeChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnSortModeChanged += h,
                h => source.ColumnSortModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnStateChangedEventArgs> ColumnStateChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnStateChangedEventHandler, System.Windows.Forms.DataGridViewColumnStateChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnStateChanged += h,
                h => source.ColumnStateChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnToolTipTextChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnToolTipTextChanged += h,
                h => source.ColumnToolTipTextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewColumnEventArgs> ColumnWidthChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewColumnEventHandler, System.Windows.Forms.DataGridViewColumnEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnWidthChanged += h,
                h => source.ColumnWidthChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CurrentCellChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CurrentCellChanged += h,
                h => source.CurrentCellChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CurrentCellDirtyStateChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CurrentCellDirtyStateChanged += h,
                h => source.CurrentCellDirtyStateChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewBindingCompleteEventArgs> DataBindingCompleteAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewBindingCompleteEventHandler, System.Windows.Forms.DataGridViewBindingCompleteEventArgs>(
                h => (sender, args) => h(args),
                h => source.DataBindingComplete += h,
                h => source.DataBindingComplete -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewDataErrorEventArgs> DataErrorAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewDataErrorEventHandler, System.Windows.Forms.DataGridViewDataErrorEventArgs>(
                h => (sender, args) => h(args),
                h => source.DataError += h,
                h => source.DataError -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> DefaultValuesNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.DefaultValuesNeeded += h,
                h => source.DefaultValuesNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewEditingControlShowingEventArgs> EditingControlShowingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewEditingControlShowingEventHandler, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs>(
                h => (sender, args) => h(args),
                h => source.EditingControlShowing += h,
                h => source.EditingControlShowing -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> NewRowNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.NewRowNeeded += h,
                h => source.NewRowNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowContextMenuStripChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowContextMenuStripChanged += h,
                h => source.RowContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventArgs> RowContextMenuStripNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler, System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowContextMenuStripNeeded += h,
                h => source.RowContextMenuStripNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowDefaultCellStyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowDefaultCellStyleChanged += h,
                h => source.RowDefaultCellStyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.QuestionEventArgs> RowDirtyStateNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.QuestionEventHandler, System.Windows.Forms.QuestionEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowDirtyStateNeeded += h,
                h => source.RowDirtyStateNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs> RowDividerDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler, System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowDividerDoubleClick += h,
                h => source.RowDividerDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowDividerHeightChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowDividerHeightChanged += h,
                h => source.RowDividerHeightChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> RowEnterAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowEnter += h,
                h => source.RowEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowErrorTextChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowErrorTextChanged += h,
                h => source.RowErrorTextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowErrorTextNeededEventArgs> RowErrorTextNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowErrorTextNeededEventHandler, System.Windows.Forms.DataGridViewRowErrorTextNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowErrorTextNeeded += h,
                h => source.RowErrorTextNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> RowHeaderMouseClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeaderMouseClick += h,
                h => source.RowHeaderMouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellMouseEventArgs> RowHeaderMouseDoubleClickAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellMouseEventHandler, System.Windows.Forms.DataGridViewCellMouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeaderMouseDoubleClick += h,
                h => source.RowHeaderMouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowHeaderCellChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeaderCellChanged += h,
                h => source.RowHeaderCellChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowHeightChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeightChanged += h,
                h => source.RowHeightChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowHeightInfoNeededEventArgs> RowHeightInfoNeededAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowHeightInfoNeededEventHandler, System.Windows.Forms.DataGridViewRowHeightInfoNeededEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeightInfoNeeded += h,
                h => source.RowHeightInfoNeeded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowHeightInfoPushedEventArgs> RowHeightInfoPushedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowHeightInfoPushedEventHandler, System.Windows.Forms.DataGridViewRowHeightInfoPushedEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowHeightInfoPushed += h,
                h => source.RowHeightInfoPushed -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> RowLeaveAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowLeave += h,
                h => source.RowLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowMinimumHeightChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowMinimumHeightChanged += h,
                h => source.RowMinimumHeightChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowPostPaintEventArgs> RowPostPaintAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowPostPaintEventHandler, System.Windows.Forms.DataGridViewRowPostPaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowPostPaint += h,
                h => source.RowPostPaint -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowPrePaintEventArgs> RowPrePaintAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowPrePaintEventHandler, System.Windows.Forms.DataGridViewRowPrePaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowPrePaint += h,
                h => source.RowPrePaint -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowsAddedEventArgs> RowsAddedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowsAddedEventHandler, System.Windows.Forms.DataGridViewRowsAddedEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowsAdded += h,
                h => source.RowsAdded -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowsRemovedEventArgs> RowsRemovedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowsRemovedEventHandler, System.Windows.Forms.DataGridViewRowsRemovedEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowsRemoved += h,
                h => source.RowsRemoved -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowStateChangedEventArgs> RowStateChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowStateChangedEventHandler, System.Windows.Forms.DataGridViewRowStateChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowStateChanged += h,
                h => source.RowStateChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> RowUnsharedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowUnshared += h,
                h => source.RowUnshared -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellEventArgs> RowValidatedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellEventHandler, System.Windows.Forms.DataGridViewCellEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowValidated += h,
                h => source.RowValidated -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewCellCancelEventArgs> RowValidatingAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewCellCancelEventHandler, System.Windows.Forms.DataGridViewCellCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.RowValidating += h,
                h => source.RowValidating -= h);
        }
         
        public static IObservable<System.Windows.Forms.ScrollEventArgs> ScrollAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ScrollEventHandler, System.Windows.Forms.ScrollEventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
         
        public static IObservable<System.EventArgs> SelectionChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectionChanged += h,
                h => source.SelectionChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewSortCompareEventArgs> SortCompareAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewSortCompareEventHandler, System.Windows.Forms.DataGridViewSortCompareEventArgs>(
                h => (sender, args) => h(args),
                h => source.SortCompare += h,
                h => source.SortCompare -= h);
        }
         
        public static IObservable<System.EventArgs> SortedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Sorted += h,
                h => source.Sorted -= h);
        }
         
        public static IObservable<System.EventArgs> StyleChangedAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StyleChanged += h,
                h => source.StyleChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> UserAddedRowAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.UserAddedRow += h,
                h => source.UserAddedRow -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowEventArgs> UserDeletedRowAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowEventHandler, System.Windows.Forms.DataGridViewRowEventArgs>(
                h => (sender, args) => h(args),
                h => source.UserDeletedRow += h,
                h => source.UserDeletedRow -= h);
        }
         
        public static IObservable<System.Windows.Forms.DataGridViewRowCancelEventArgs> UserDeletingRowAsObservable(this DataGridView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DataGridViewRowCancelEventHandler, System.Windows.Forms.DataGridViewRowCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.UserDeletingRow += h,
                h => source.UserDeletingRow -= h);
        }
            }
     
    public static class DateTimePickerEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FormatChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FormatChanged += h,
                h => source.FormatChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CloseUpAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CloseUp += h,
                h => source.CloseUp -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ValueChangedAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueChanged += h,
                h => source.ValueChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownAsObservable(this DateTimePicker source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDown += h,
                h => source.DropDown -= h);
        }
            }
     
    public static class FormEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AutoValidateChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoValidateChanged += h,
                h => source.AutoValidateChanged -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> HelpButtonClickedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpButtonClicked += h,
                h => source.HelpButtonClicked -= h);
        }
         
        public static IObservable<System.EventArgs> MaximizedBoundsChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MaximizedBoundsChanged += h,
                h => source.MaximizedBoundsChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MaximumSizeChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MaximumSizeChanged += h,
                h => source.MaximumSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MarginChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MarginChanged += h,
                h => source.MarginChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MinimumSizeChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MinimumSizeChanged += h,
                h => source.MinimumSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ActivatedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Activated += h,
                h => source.Activated -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> ClosingAsObservable(this Form source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Closing += h,
                h => source.Closing -= h);
        }
         
        public static IObservable<System.EventArgs> ClosedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Closed += h,
                h => source.Closed -= h);
        }
         
        public static IObservable<System.EventArgs> DeactivateAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Deactivate += h,
                h => source.Deactivate -= h);
        }
         
        public static IObservable<System.Windows.Forms.FormClosingEventArgs> FormClosingAsObservable(this Form source)
        {
            return Observable.FromEvent<System.Windows.Forms.FormClosingEventHandler, System.Windows.Forms.FormClosingEventArgs>(
                h => (sender, args) => h(args),
                h => source.FormClosing += h,
                h => source.FormClosing -= h);
        }
         
        public static IObservable<System.Windows.Forms.FormClosedEventArgs> FormClosedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.Windows.Forms.FormClosedEventHandler, System.Windows.Forms.FormClosedEventArgs>(
                h => (sender, args) => h(args),
                h => source.FormClosed += h,
                h => source.FormClosed -= h);
        }
         
        public static IObservable<System.EventArgs> LoadAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Load += h,
                h => source.Load -= h);
        }
         
        public static IObservable<System.EventArgs> MdiChildActivateAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MdiChildActivate += h,
                h => source.MdiChildActivate -= h);
        }
         
        public static IObservable<System.EventArgs> MenuCompleteAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MenuComplete += h,
                h => source.MenuComplete -= h);
        }
         
        public static IObservable<System.EventArgs> MenuStartAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MenuStart += h,
                h => source.MenuStart -= h);
        }
         
        public static IObservable<System.Windows.Forms.InputLanguageChangedEventArgs> InputLanguageChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.Windows.Forms.InputLanguageChangedEventHandler, System.Windows.Forms.InputLanguageChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.InputLanguageChanged += h,
                h => source.InputLanguageChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.InputLanguageChangingEventArgs> InputLanguageChangingAsObservable(this Form source)
        {
            return Observable.FromEvent<System.Windows.Forms.InputLanguageChangingEventHandler, System.Windows.Forms.InputLanguageChangingEventArgs>(
                h => (sender, args) => h(args),
                h => source.InputLanguageChanging += h,
                h => source.InputLanguageChanging -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ShownAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Shown += h,
                h => source.Shown -= h);
        }
         
        public static IObservable<System.Windows.Forms.DpiChangedEventArgs> DpiChangedAsObservable(this Form source)
        {
            return Observable.FromEvent<System.Windows.Forms.DpiChangedEventHandler, System.Windows.Forms.DpiChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.DpiChanged += h,
                h => source.DpiChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ResizeBeginAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ResizeBegin += h,
                h => source.ResizeBegin -= h);
        }
         
        public static IObservable<System.EventArgs> ResizeEndAsObservable(this Form source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ResizeEnd += h,
                h => source.ResizeEnd -= h);
        }
            }
     
    public static class PanelEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this Panel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this Panel source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this Panel source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this Panel source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this Panel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
            }
     
    public static class DomainUpDownEventExtensions
    {
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this DomainUpDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedItemChangedAsObservable(this DomainUpDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedItemChanged += h,
                h => source.SelectedItemChanged -= h);
        }
            }
     
    public static class UpDownBaseEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.EventArgs> MouseHoverAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseHover += h,
                h => source.MouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this UpDownBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
            }
     
    public static class ErrorProviderEventExtensions
    {
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this ErrorProvider source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
            }
     
    public static class FileDialogEventExtensions
    {
         
        public static IObservable<System.ComponentModel.CancelEventArgs> FileOkAsObservable(this FileDialog source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.FileOk += h,
                h => source.FileOk -= h);
        }
            }
     
    public static class FolderBrowserDialogEventExtensions
    {
         
        public static IObservable<System.EventArgs> HelpRequestAsObservable(this FolderBrowserDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequest += h,
                h => source.HelpRequest -= h);
        }
            }
     
    public static class FontDialogEventExtensions
    {
         
        public static IObservable<System.EventArgs> ApplyAsObservable(this FontDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Apply += h,
                h => source.Apply -= h);
        }
            }
     
    public static class GroupBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this GroupBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
            }
     
    public static class ScrollBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.ScrollEventArgs> ScrollAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.ScrollEventHandler, System.Windows.Forms.ScrollEventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
         
        public static IObservable<System.EventArgs> ValueChangedAsObservable(this ScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueChanged += h,
                h => source.ValueChanged -= h);
        }
            }
     
    public static class ImageListEventExtensions
    {
         
        public static IObservable<System.EventArgs> RecreateHandleAsObservable(this ImageList source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RecreateHandle += h,
                h => source.RecreateHandle -= h);
        }
            }
     
    public static class LabelEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this Label source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this Label source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this Label source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextAlignChangedAsObservable(this Label source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextAlignChanged += h,
                h => source.TextAlignChanged -= h);
        }
            }
     
    public static class LinkLabelEventExtensions
    {
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this LinkLabel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.LinkLabelLinkClickedEventArgs> LinkClickedAsObservable(this LinkLabel source)
        {
            return Observable.FromEvent<System.Windows.Forms.LinkLabelLinkClickedEventHandler, System.Windows.Forms.LinkLabelLinkClickedEventArgs>(
                h => (sender, args) => h(args),
                h => source.LinkClicked += h,
                h => source.LinkClicked -= h);
        }
            }
     
    public static class ListViewEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.LabelEditEventArgs> AfterLabelEditAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.LabelEditEventHandler, System.Windows.Forms.LabelEditEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterLabelEdit += h,
                h => source.AfterLabelEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.LabelEditEventArgs> BeforeLabelEditAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.LabelEditEventHandler, System.Windows.Forms.LabelEditEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeLabelEdit += h,
                h => source.BeforeLabelEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.CacheVirtualItemsEventArgs> CacheVirtualItemsAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.CacheVirtualItemsEventHandler, System.Windows.Forms.CacheVirtualItemsEventArgs>(
                h => (sender, args) => h(args),
                h => source.CacheVirtualItems += h,
                h => source.CacheVirtualItems -= h);
        }
         
        public static IObservable<System.Windows.Forms.ColumnClickEventArgs> ColumnClickAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ColumnClickEventHandler, System.Windows.Forms.ColumnClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnClick += h,
                h => source.ColumnClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.ColumnReorderedEventArgs> ColumnReorderedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ColumnReorderedEventHandler, System.Windows.Forms.ColumnReorderedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnReordered += h,
                h => source.ColumnReordered -= h);
        }
         
        public static IObservable<System.Windows.Forms.ColumnWidthChangedEventArgs> ColumnWidthChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ColumnWidthChangedEventHandler, System.Windows.Forms.ColumnWidthChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnWidthChanged += h,
                h => source.ColumnWidthChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ColumnWidthChangingEventArgs> ColumnWidthChangingAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ColumnWidthChangingEventHandler, System.Windows.Forms.ColumnWidthChangingEventArgs>(
                h => (sender, args) => h(args),
                h => source.ColumnWidthChanging += h,
                h => source.ColumnWidthChanging -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawListViewColumnHeaderEventArgs> DrawColumnHeaderAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawListViewColumnHeaderEventHandler, System.Windows.Forms.DrawListViewColumnHeaderEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawColumnHeader += h,
                h => source.DrawColumnHeader -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawListViewItemEventArgs> DrawItemAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawListViewItemEventHandler, System.Windows.Forms.DrawListViewItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawListViewSubItemEventArgs> DrawSubItemAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawListViewSubItemEventHandler, System.Windows.Forms.DrawListViewSubItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawSubItem += h,
                h => source.DrawSubItem -= h);
        }
         
        public static IObservable<System.EventArgs> ItemActivateAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemActivate += h,
                h => source.ItemActivate -= h);
        }
         
        public static IObservable<System.Windows.Forms.ItemCheckEventArgs> ItemCheckAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ItemCheckEventHandler, System.Windows.Forms.ItemCheckEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemCheck += h,
                h => source.ItemCheck -= h);
        }
         
        public static IObservable<System.Windows.Forms.ItemCheckedEventArgs> ItemCheckedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ItemCheckedEventHandler, System.Windows.Forms.ItemCheckedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemChecked += h,
                h => source.ItemChecked -= h);
        }
         
        public static IObservable<System.Windows.Forms.ItemDragEventArgs> ItemDragAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ItemDragEventHandler, System.Windows.Forms.ItemDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemDrag += h,
                h => source.ItemDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.ListViewItemMouseHoverEventArgs> ItemMouseHoverAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ListViewItemMouseHoverEventHandler, System.Windows.Forms.ListViewItemMouseHoverEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemMouseHover += h,
                h => source.ItemMouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.ListViewItemSelectionChangedEventArgs> ItemSelectionChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ListViewItemSelectionChangedEventHandler, System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemSelectionChanged += h,
                h => source.ItemSelectionChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.RetrieveVirtualItemEventArgs> RetrieveVirtualItemAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.RetrieveVirtualItemEventHandler, System.Windows.Forms.RetrieveVirtualItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.RetrieveVirtualItem += h,
                h => source.RetrieveVirtualItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.SearchForVirtualItemEventArgs> SearchForVirtualItemAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.SearchForVirtualItemEventHandler, System.Windows.Forms.SearchForVirtualItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.SearchForVirtualItem += h,
                h => source.SearchForVirtualItem -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedIndexChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedIndexChanged += h,
                h => source.SelectedIndexChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs> VirtualItemsSelectionRangeChangedAsObservable(this ListView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventHandler, System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.VirtualItemsSelectionRangeChanged += h,
                h => source.VirtualItemsSelectionRangeChanged -= h);
        }
            }
     
    public static class MainMenuEventExtensions
    {
         
        public static IObservable<System.EventArgs> CollapseAsObservable(this MainMenu source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Collapse += h,
                h => source.Collapse -= h);
        }
            }
     
    public static class MaskedTextBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> AcceptsTabChangedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AcceptsTabChanged += h,
                h => source.AcceptsTabChanged -= h);
        }
         
        public static IObservable<System.EventArgs> IsOverwriteModeChangedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.IsOverwriteModeChanged += h,
                h => source.IsOverwriteModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MaskChangedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MaskChanged += h,
                h => source.MaskChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.MaskInputRejectedEventArgs> MaskInputRejectedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.MaskInputRejectedEventHandler, System.Windows.Forms.MaskInputRejectedEventArgs>(
                h => (sender, args) => h(args),
                h => source.MaskInputRejected += h,
                h => source.MaskInputRejected -= h);
        }
         
        public static IObservable<System.EventArgs> MultilineChangedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MultilineChanged += h,
                h => source.MultilineChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextAlignChangedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextAlignChanged += h,
                h => source.TextAlignChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.TypeValidationEventArgs> TypeValidationCompletedAsObservable(this MaskedTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.TypeValidationEventHandler, System.Windows.Forms.TypeValidationEventArgs>(
                h => (sender, args) => h(args),
                h => source.TypeValidationCompleted += h,
                h => source.TypeValidationCompleted -= h);
        }
            }
     
    public static class MenuItemEventExtensions
    {
         
        public static IObservable<System.EventArgs> ClickAsObservable(this MenuItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawItemEventArgs> DrawItemAsObservable(this MenuItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawItemEventHandler, System.Windows.Forms.DrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.MeasureItemEventArgs> MeasureItemAsObservable(this MenuItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.MeasureItemEventHandler, System.Windows.Forms.MeasureItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.MeasureItem += h,
                h => source.MeasureItem -= h);
        }
         
        public static IObservable<System.EventArgs> PopupAsObservable(this MenuItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Popup += h,
                h => source.Popup -= h);
        }
         
        public static IObservable<System.EventArgs> SelectAsObservable(this MenuItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Select += h,
                h => source.Select -= h);
        }
            }
     
    public static class MenuStripEventExtensions
    {
         
        public static IObservable<System.EventArgs> MenuActivateAsObservable(this MenuStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MenuActivate += h,
                h => source.MenuActivate -= h);
        }
         
        public static IObservable<System.EventArgs> MenuDeactivateAsObservable(this MenuStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MenuDeactivate += h,
                h => source.MenuDeactivate -= h);
        }
            }
     
    public static class MonthCalendarEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.DateRangeEventArgs> DateChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.Windows.Forms.DateRangeEventHandler, System.Windows.Forms.DateRangeEventArgs>(
                h => (sender, args) => h(args),
                h => source.DateChanged += h,
                h => source.DateChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DateRangeEventArgs> DateSelectedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.Windows.Forms.DateRangeEventHandler, System.Windows.Forms.DateRangeEventArgs>(
                h => (sender, args) => h(args),
                h => source.DateSelected += h,
                h => source.DateSelected -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this MonthCalendar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
            }
     
    public static class NotifyIconEventExtensions
    {
         
        public static IObservable<System.EventArgs> BalloonTipClickedAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BalloonTipClicked += h,
                h => source.BalloonTipClicked -= h);
        }
         
        public static IObservable<System.EventArgs> BalloonTipClosedAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BalloonTipClosed += h,
                h => source.BalloonTipClosed -= h);
        }
         
        public static IObservable<System.EventArgs> BalloonTipShownAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BalloonTipShown += h,
                h => source.BalloonTipShown -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this NotifyIcon source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
            }
     
    public static class NumericUpDownEventExtensions
    {
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this NumericUpDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this NumericUpDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ValueChangedAsObservable(this NumericUpDown source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueChanged += h,
                h => source.ValueChanged -= h);
        }
            }
     
    public static class PictureBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.ComponentModel.AsyncCompletedEventArgs> LoadCompletedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.ComponentModel.AsyncCompletedEventHandler, System.ComponentModel.AsyncCompletedEventArgs>(
                h => (sender, args) => h(args),
                h => source.LoadCompleted += h,
                h => source.LoadCompleted -= h);
        }
         
        public static IObservable<System.ComponentModel.ProgressChangedEventArgs> LoadProgressChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.ComponentModel.ProgressChangedEventHandler, System.ComponentModel.ProgressChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.LoadProgressChanged += h,
                h => source.LoadProgressChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SizeModeChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SizeModeChanged += h,
                h => source.SizeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this PictureBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
            }
     
    public static class PrintPreviewControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this PrintPreviewControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> StartPageChangedAsObservable(this PrintPreviewControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StartPageChanged += h,
                h => source.StartPageChanged -= h);
        }
            }
     
    public static class PrintPreviewDialogEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AutoValidateChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoValidateChanged += h,
                h => source.AutoValidateChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuStripChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuStripChanged += h,
                h => source.ContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MaximumSizeChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MaximumSizeChanged += h,
                h => source.MaximumSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MarginChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MarginChanged += h,
                h => source.MarginChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MinimumSizeChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MinimumSizeChanged += h,
                h => source.MinimumSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SizeChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SizeChanged += h,
                h => source.SizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VisibleChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VisibleChanged += h,
                h => source.VisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuChangedAsObservable(this PrintPreviewDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuChanged += h,
                h => source.ContextMenuChanged -= h);
        }
            }
     
    public static class ProgressBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
            }
     
    public static class PropertyGridEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.PropertyValueChangedEventArgs> PropertyValueChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.PropertyValueChangedEventHandler, System.Windows.Forms.PropertyValueChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.PropertyValueChanged += h,
                h => source.PropertyValueChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PropertyTabChangedEventArgs> PropertyTabChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.PropertyTabChangedEventHandler, System.Windows.Forms.PropertyTabChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.PropertyTabChanged += h,
                h => source.PropertyTabChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PropertySortChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PropertySortChanged += h,
                h => source.PropertySortChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.SelectedGridItemChangedEventArgs> SelectedGridItemChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.Windows.Forms.SelectedGridItemChangedEventHandler, System.Windows.Forms.SelectedGridItemChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedGridItemChanged += h,
                h => source.SelectedGridItemChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedObjectsChangedAsObservable(this PropertyGrid source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedObjectsChanged += h,
                h => source.SelectedObjectsChanged -= h);
        }
            }
     
    public static class RadioButtonEventExtensions
    {
         
        public static IObservable<System.EventArgs> AppearanceChangedAsObservable(this RadioButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AppearanceChanged += h,
                h => source.AppearanceChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this RadioButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this RadioButton source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> CheckedChangedAsObservable(this RadioButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckedChanged += h,
                h => source.CheckedChanged -= h);
        }
            }
     
    public static class RichTextBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ContentsResizedEventArgs> ContentsResizedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.ContentsResizedEventHandler, System.Windows.Forms.ContentsResizedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ContentsResized += h,
                h => source.ContentsResized -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragDropAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragDrop += h,
                h => source.DragDrop -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragEnterAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragEnter += h,
                h => source.DragEnter -= h);
        }
         
        public static IObservable<System.EventArgs> DragLeaveAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DragLeave += h,
                h => source.DragLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragOverAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragOver += h,
                h => source.DragOver -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryContinueDragEventArgs> QueryContinueDragAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryContinueDragEventHandler, System.Windows.Forms.QueryContinueDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryContinueDrag += h,
                h => source.QueryContinueDrag -= h);
        }
         
        public static IObservable<System.EventArgs> HScrollAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HScroll += h,
                h => source.HScroll -= h);
        }
         
        public static IObservable<System.Windows.Forms.LinkClickedEventArgs> LinkClickedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.Windows.Forms.LinkClickedEventHandler, System.Windows.Forms.LinkClickedEventArgs>(
                h => (sender, args) => h(args),
                h => source.LinkClicked += h,
                h => source.LinkClicked -= h);
        }
         
        public static IObservable<System.EventArgs> ImeChangeAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeChange += h,
                h => source.ImeChange -= h);
        }
         
        public static IObservable<System.EventArgs> ProtectedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Protected += h,
                h => source.Protected -= h);
        }
         
        public static IObservable<System.EventArgs> SelectionChangedAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectionChanged += h,
                h => source.SelectionChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VScrollAsObservable(this RichTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VScroll += h,
                h => source.VScroll -= h);
        }
            }
     
    public static class SplitContainerEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlAddedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlAdded += h,
                h => source.ControlAdded -= h);
        }
         
        public static IObservable<System.Windows.Forms.ControlEventArgs> ControlRemovedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.Windows.Forms.ControlEventHandler, System.Windows.Forms.ControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.ControlRemoved += h,
                h => source.ControlRemoved -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.SplitterCancelEventArgs> SplitterMovingAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.Windows.Forms.SplitterCancelEventHandler, System.Windows.Forms.SplitterCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.SplitterMoving += h,
                h => source.SplitterMoving -= h);
        }
         
        public static IObservable<System.Windows.Forms.SplitterEventArgs> SplitterMovedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.Windows.Forms.SplitterEventHandler, System.Windows.Forms.SplitterEventArgs>(
                h => (sender, args) => h(args),
                h => source.SplitterMoved += h,
                h => source.SplitterMoved -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this SplitContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
            }
     
    public static class SplitterEventExtensions
    {
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.Windows.Forms.SplitterEventArgs> SplitterMovingAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.Windows.Forms.SplitterEventHandler, System.Windows.Forms.SplitterEventArgs>(
                h => (sender, args) => h(args),
                h => source.SplitterMoving += h,
                h => source.SplitterMoving -= h);
        }
         
        public static IObservable<System.Windows.Forms.SplitterEventArgs> SplitterMovedAsObservable(this Splitter source)
        {
            return Observable.FromEvent<System.Windows.Forms.SplitterEventHandler, System.Windows.Forms.SplitterEventArgs>(
                h => (sender, args) => h(args),
                h => source.SplitterMoved += h,
                h => source.SplitterMoved -= h);
        }
            }
     
    public static class SplitterPanelEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VisibleChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VisibleChanged += h,
                h => source.VisibleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this SplitterPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
            }
     
    public static class StatusBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.StatusBarDrawItemEventArgs> DrawItemAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.StatusBarDrawItemEventHandler, System.Windows.Forms.StatusBarDrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.Windows.Forms.StatusBarPanelClickEventArgs> PanelClickAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.StatusBarPanelClickEventHandler, System.Windows.Forms.StatusBarPanelClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.PanelClick += h,
                h => source.PanelClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this StatusBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
            }
     
    public static class StatusStripEventExtensions
    {
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this StatusStrip source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
            }
     
    public static class TabControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawItemEventArgs> DrawItemAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawItemEventHandler, System.Windows.Forms.DrawItemEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawItem += h,
                h => source.DrawItem -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedIndexChangedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedIndexChanged += h,
                h => source.SelectedIndexChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.TabControlCancelEventArgs> SelectingAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.TabControlCancelEventHandler, System.Windows.Forms.TabControlCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Selecting += h,
                h => source.Selecting -= h);
        }
         
        public static IObservable<System.Windows.Forms.TabControlEventArgs> SelectedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.TabControlEventHandler, System.Windows.Forms.TabControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.Selected += h,
                h => source.Selected -= h);
        }
         
        public static IObservable<System.Windows.Forms.TabControlCancelEventArgs> DeselectingAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.TabControlCancelEventHandler, System.Windows.Forms.TabControlCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Deselecting += h,
                h => source.Deselecting -= h);
        }
         
        public static IObservable<System.Windows.Forms.TabControlEventArgs> DeselectedAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.TabControlEventHandler, System.Windows.Forms.TabControlEventArgs>(
                h => (sender, args) => h(args),
                h => source.Deselected += h,
                h => source.Deselected -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this TabControl source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
            }
     
    public static class TableLayoutPanelEventExtensions
    {
         
        public static IObservable<System.Windows.Forms.TableLayoutCellPaintEventArgs> CellPaintAsObservable(this TableLayoutPanel source)
        {
            return Observable.FromEvent<System.Windows.Forms.TableLayoutCellPaintEventHandler, System.Windows.Forms.TableLayoutCellPaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.CellPaint += h,
                h => source.CellPaint -= h);
        }
            }
     
    public static class TabPageEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VisibleChangedAsObservable(this TabPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VisibleChanged += h,
                h => source.VisibleChanged -= h);
        }
            }
     
    public static class ThreadExceptionDialogEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ThreadExceptionDialog source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
            }
     
    public static class TimerEventExtensions
    {
         
        public static IObservable<System.EventArgs> TickAsObservable(this Timer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Tick += h,
                h => source.Tick -= h);
        }
            }
     
    public static class ToolBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolBarButtonClickEventArgs> ButtonClickAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolBarButtonClickEventHandler, System.Windows.Forms.ToolBarButtonClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.ButtonClick += h,
                h => source.ButtonClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolBarButtonClickEventArgs> ButtonDropDownAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolBarButtonClickEventHandler, System.Windows.Forms.ToolBarButtonClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.ButtonDropDown += h,
                h => source.ButtonDropDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ToolBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
            }
     
    public static class ToolStripButtonEventExtensions
    {
         
        public static IObservable<System.EventArgs> CheckedChangedAsObservable(this ToolStripButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckedChanged += h,
                h => source.CheckedChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CheckStateChangedAsObservable(this ToolStripButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckStateChanged += h,
                h => source.CheckStateChanged -= h);
        }
            }
     
    public static class ToolStripItemEventExtensions
    {
         
        public static IObservable<System.EventArgs> AvailableChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AvailableChanged += h,
                h => source.AvailableChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.EventArgs> DisplayStyleChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DisplayStyleChanged += h,
                h => source.DisplayStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragDropAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragDrop += h,
                h => source.DragDrop -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragEnterAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragEnter += h,
                h => source.DragEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragOverAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragOver += h,
                h => source.DragOver -= h);
        }
         
        public static IObservable<System.EventArgs> DragLeaveAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DragLeave += h,
                h => source.DragLeave -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.EventArgs> MouseHoverAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseHover += h,
                h => source.MouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.EventArgs> OwnerChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.OwnerChanged += h,
                h => source.OwnerChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryContinueDragEventArgs> QueryContinueDragAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryContinueDragEventHandler, System.Windows.Forms.QueryContinueDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryContinueDrag += h,
                h => source.QueryContinueDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryAccessibilityHelpEventHandler, System.Windows.Forms.QueryAccessibilityHelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryAccessibilityHelp += h,
                h => source.QueryAccessibilityHelp -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> VisibleChangedAsObservable(this ToolStripItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.VisibleChanged += h,
                h => source.VisibleChanged -= h);
        }
            }
     
    public static class ToolStripComboBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDown += h,
                h => source.DropDown -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownClosedAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownClosed += h,
                h => source.DropDownClosed -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownStyleChangedAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownStyleChanged += h,
                h => source.DropDownStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> SelectedIndexChangedAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.SelectedIndexChanged += h,
                h => source.SelectedIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextUpdateAsObservable(this ToolStripComboBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextUpdate += h,
                h => source.TextUpdate -= h);
        }
            }
     
    public static class ToolStripControlHostEventExtensions
    {
         
        public static IObservable<System.EventArgs> DisplayStyleChangedAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DisplayStyleChanged += h,
                h => source.DisplayStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.EventArgs> GotFocusAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.GotFocus += h,
                h => source.GotFocus -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.EventArgs> LostFocusAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LostFocus += h,
                h => source.LostFocus -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> ValidatingAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Validating += h,
                h => source.Validating -= h);
        }
         
        public static IObservable<System.EventArgs> ValidatedAsObservable(this ToolStripControlHost source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Validated += h,
                h => source.Validated -= h);
        }
            }
     
    public static class ToolStripContainerEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ContextMenuStripChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ContextMenuStripChanged += h,
                h => source.ContextMenuStripChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this ToolStripContainer source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
            }
     
    public static class ToolStripContentPanelEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CausesValidationChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CausesValidationChanged += h,
                h => source.CausesValidationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DockChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DockChanged += h,
                h => source.DockChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LoadAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Load += h,
                h => source.Load -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RendererChangedAsObservable(this ToolStripContentPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RendererChanged += h,
                h => source.RendererChanged -= h);
        }
            }
     
    public static class ToolStripDropDownItemEventExtensions
    {
         
        public static IObservable<System.EventArgs> DropDownClosedAsObservable(this ToolStripDropDownItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownClosed += h,
                h => source.DropDownClosed -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownOpeningAsObservable(this ToolStripDropDownItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownOpening += h,
                h => source.DropDownOpening -= h);
        }
         
        public static IObservable<System.EventArgs> DropDownOpenedAsObservable(this ToolStripDropDownItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownOpened += h,
                h => source.DropDownOpened -= h);
        }
         
        public static IObservable<System.Windows.Forms.ToolStripItemClickedEventArgs> DropDownItemClickedAsObservable(this ToolStripDropDownItem source)
        {
            return Observable.FromEvent<System.Windows.Forms.ToolStripItemClickedEventHandler, System.Windows.Forms.ToolStripItemClickedEventArgs>(
                h => (sender, args) => h(args),
                h => source.DropDownItemClicked += h,
                h => source.DropDownItemClicked -= h);
        }
            }
     
    public static class ToolStripMenuItemEventExtensions
    {
         
        public static IObservable<System.EventArgs> CheckedChangedAsObservable(this ToolStripMenuItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckedChanged += h,
                h => source.CheckedChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CheckStateChangedAsObservable(this ToolStripMenuItem source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CheckStateChanged += h,
                h => source.CheckStateChanged -= h);
        }
            }
     
    public static class ToolStripPanelEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ToolStripPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RendererChangedAsObservable(this ToolStripPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RendererChanged += h,
                h => source.RendererChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabIndexChangedAsObservable(this ToolStripPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabIndexChanged += h,
                h => source.TabIndexChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TabStopChangedAsObservable(this ToolStripPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TabStopChanged += h,
                h => source.TabStopChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolStripPanel source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
            }
     
    public static class ToolStripProgressBarEventExtensions
    {
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.EventArgs> LocationChangedAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.LocationChanged += h,
                h => source.LocationChanged -= h);
        }
         
        public static IObservable<System.EventArgs> OwnerChangedAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.OwnerChanged += h,
                h => source.OwnerChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ValidatedAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Validated += h,
                h => source.Validated -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> ValidatingAsObservable(this ToolStripProgressBar source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.Validating += h,
                h => source.Validating -= h);
        }
            }
     
    public static class ToolStripSeparatorEventExtensions
    {
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this ToolStripSeparator source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> DisplayStyleChangedAsObservable(this ToolStripSeparator source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DisplayStyleChanged += h,
                h => source.DisplayStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this ToolStripSeparator source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
            }
     
    public static class ToolStripSplitButtonEventExtensions
    {
         
        public static IObservable<System.EventArgs> ButtonClickAsObservable(this ToolStripSplitButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ButtonClick += h,
                h => source.ButtonClick -= h);
        }
         
        public static IObservable<System.EventArgs> ButtonDoubleClickAsObservable(this ToolStripSplitButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ButtonDoubleClick += h,
                h => source.ButtonDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> DefaultItemChangedAsObservable(this ToolStripSplitButton source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DefaultItemChanged += h,
                h => source.DefaultItemChanged -= h);
        }
            }
     
    public static class ToolStripTextBoxEventExtensions
    {
         
        public static IObservable<System.EventArgs> AcceptsTabChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AcceptsTabChanged += h,
                h => source.AcceptsTabChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BorderStyleChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BorderStyleChanged += h,
                h => source.BorderStyleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> HideSelectionChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.HideSelectionChanged += h,
                h => source.HideSelectionChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ModifiedChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ModifiedChanged += h,
                h => source.ModifiedChanged -= h);
        }
         
        public static IObservable<System.EventArgs> MultilineChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MultilineChanged += h,
                h => source.MultilineChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ReadOnlyChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ReadOnlyChanged += h,
                h => source.ReadOnlyChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextBoxTextAlignChangedAsObservable(this ToolStripTextBox source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextBoxTextAlignChanged += h,
                h => source.TextBoxTextAlignChanged -= h);
        }
            }
     
    public static class ToolTipEventExtensions
    {
         
        public static IObservable<System.Windows.Forms.DrawToolTipEventArgs> DrawAsObservable(this ToolTip source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawToolTipEventHandler, System.Windows.Forms.DrawToolTipEventArgs>(
                h => (sender, args) => h(args),
                h => source.Draw += h,
                h => source.Draw -= h);
        }
         
        public static IObservable<System.Windows.Forms.PopupEventArgs> PopupAsObservable(this ToolTip source)
        {
            return Observable.FromEvent<System.Windows.Forms.PopupEventHandler, System.Windows.Forms.PopupEventArgs>(
                h => (sender, args) => h(args),
                h => source.Popup += h,
                h => source.Popup -= h);
        }
            }
     
    public static class TrackBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ScrollAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Scroll += h,
                h => source.Scroll -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.EventArgs> ValueChangedAsObservable(this TrackBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ValueChanged += h,
                h => source.ValueChanged -= h);
        }
            }
     
    public static class TreeViewEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.NodeLabelEditEventArgs> BeforeLabelEditAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.NodeLabelEditEventHandler, System.Windows.Forms.NodeLabelEditEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeLabelEdit += h,
                h => source.BeforeLabelEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.NodeLabelEditEventArgs> AfterLabelEditAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.NodeLabelEditEventHandler, System.Windows.Forms.NodeLabelEditEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterLabelEdit += h,
                h => source.AfterLabelEdit -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewCancelEventArgs> BeforeCheckAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewCancelEventHandler, System.Windows.Forms.TreeViewCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeCheck += h,
                h => source.BeforeCheck -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewEventArgs> AfterCheckAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewEventHandler, System.Windows.Forms.TreeViewEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterCheck += h,
                h => source.AfterCheck -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewCancelEventArgs> BeforeCollapseAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewCancelEventHandler, System.Windows.Forms.TreeViewCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeCollapse += h,
                h => source.BeforeCollapse -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewEventArgs> AfterCollapseAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewEventHandler, System.Windows.Forms.TreeViewEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterCollapse += h,
                h => source.AfterCollapse -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewCancelEventArgs> BeforeExpandAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewCancelEventHandler, System.Windows.Forms.TreeViewCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeExpand += h,
                h => source.BeforeExpand -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewEventArgs> AfterExpandAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewEventHandler, System.Windows.Forms.TreeViewEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterExpand += h,
                h => source.AfterExpand -= h);
        }
         
        public static IObservable<System.Windows.Forms.DrawTreeNodeEventArgs> DrawNodeAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.DrawTreeNodeEventHandler, System.Windows.Forms.DrawTreeNodeEventArgs>(
                h => (sender, args) => h(args),
                h => source.DrawNode += h,
                h => source.DrawNode -= h);
        }
         
        public static IObservable<System.Windows.Forms.ItemDragEventArgs> ItemDragAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.ItemDragEventHandler, System.Windows.Forms.ItemDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.ItemDrag += h,
                h => source.ItemDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeNodeMouseHoverEventArgs> NodeMouseHoverAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeNodeMouseHoverEventHandler, System.Windows.Forms.TreeNodeMouseHoverEventArgs>(
                h => (sender, args) => h(args),
                h => source.NodeMouseHover += h,
                h => source.NodeMouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewCancelEventArgs> BeforeSelectAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewCancelEventHandler, System.Windows.Forms.TreeViewCancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.BeforeSelect += h,
                h => source.BeforeSelect -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeViewEventArgs> AfterSelectAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeViewEventHandler, System.Windows.Forms.TreeViewEventArgs>(
                h => (sender, args) => h(args),
                h => source.AfterSelect += h,
                h => source.AfterSelect -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeNodeMouseClickEventArgs> NodeMouseClickAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeNodeMouseClickEventHandler, System.Windows.Forms.TreeNodeMouseClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.NodeMouseClick += h,
                h => source.NodeMouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.TreeNodeMouseClickEventArgs> NodeMouseDoubleClickAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.Windows.Forms.TreeNodeMouseClickEventHandler, System.Windows.Forms.TreeNodeMouseClickEventArgs>(
                h => (sender, args) => h(args),
                h => source.NodeMouseDoubleClick += h,
                h => source.NodeMouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftLayoutChangedAsObservable(this TreeView source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftLayoutChanged += h,
                h => source.RightToLeftLayoutChanged -= h);
        }
            }
     
    public static class UserControlEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this UserControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
         
        public static IObservable<System.EventArgs> AutoValidateChangedAsObservable(this UserControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoValidateChanged += h,
                h => source.AutoValidateChanged -= h);
        }
         
        public static IObservable<System.EventArgs> LoadAsObservable(this UserControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Load += h,
                h => source.Load -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this UserControl source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
            }
     
    public static class VScrollBarEventExtensions
    {
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this VScrollBar source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
            }
     
    public static class WebBrowserEventExtensions
    {
         
        public static IObservable<System.EventArgs> PaddingChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.PaddingChanged += h,
                h => source.PaddingChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CanGoBackChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CanGoBackChanged += h,
                h => source.CanGoBackChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CanGoForwardChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CanGoForwardChanged += h,
                h => source.CanGoForwardChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.WebBrowserDocumentCompletedEventArgs> DocumentCompletedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.Windows.Forms.WebBrowserDocumentCompletedEventHandler, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs>(
                h => (sender, args) => h(args),
                h => source.DocumentCompleted += h,
                h => source.DocumentCompleted -= h);
        }
         
        public static IObservable<System.EventArgs> DocumentTitleChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DocumentTitleChanged += h,
                h => source.DocumentTitleChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EncryptionLevelChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EncryptionLevelChanged += h,
                h => source.EncryptionLevelChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FileDownloadAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FileDownload += h,
                h => source.FileDownload -= h);
        }
         
        public static IObservable<System.Windows.Forms.WebBrowserNavigatedEventArgs> NavigatedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.Windows.Forms.WebBrowserNavigatedEventHandler, System.Windows.Forms.WebBrowserNavigatedEventArgs>(
                h => (sender, args) => h(args),
                h => source.Navigated += h,
                h => source.Navigated -= h);
        }
         
        public static IObservable<System.Windows.Forms.WebBrowserNavigatingEventArgs> NavigatingAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.Windows.Forms.WebBrowserNavigatingEventHandler, System.Windows.Forms.WebBrowserNavigatingEventArgs>(
                h => (sender, args) => h(args),
                h => source.Navigating += h,
                h => source.Navigating -= h);
        }
         
        public static IObservable<System.ComponentModel.CancelEventArgs> NewWindowAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(
                h => (sender, args) => h(args),
                h => source.NewWindow += h,
                h => source.NewWindow -= h);
        }
         
        public static IObservable<System.Windows.Forms.WebBrowserProgressChangedEventArgs> ProgressChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.Windows.Forms.WebBrowserProgressChangedEventHandler, System.Windows.Forms.WebBrowserProgressChangedEventArgs>(
                h => (sender, args) => h(args),
                h => source.ProgressChanged += h,
                h => source.ProgressChanged -= h);
        }
         
        public static IObservable<System.EventArgs> StatusTextChangedAsObservable(this WebBrowser source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StatusTextChanged += h,
                h => source.StatusTextChanged -= h);
        }
            }
     
    public static class WebBrowserBaseEventExtensions
    {
         
        public static IObservable<System.EventArgs> BackgroundImageLayoutChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageLayoutChanged += h,
                h => source.BackgroundImageLayoutChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnterAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Enter += h,
                h => source.Enter -= h);
        }
         
        public static IObservable<System.EventArgs> LeaveAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Leave += h,
                h => source.Leave -= h);
        }
         
        public static IObservable<System.EventArgs> MouseCaptureChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseCaptureChanged += h,
                h => source.MouseCaptureChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseClickAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseClick += h,
                h => source.MouseClick -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDoubleClickAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDoubleClick += h,
                h => source.MouseDoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> BackColorChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackColorChanged += h,
                h => source.BackColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BackgroundImageChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BackgroundImageChanged += h,
                h => source.BackgroundImageChanged -= h);
        }
         
        public static IObservable<System.EventArgs> BindingContextChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.BindingContextChanged += h,
                h => source.BindingContextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> CursorChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.CursorChanged += h,
                h => source.CursorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> EnabledChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.EnabledChanged += h,
                h => source.EnabledChanged -= h);
        }
         
        public static IObservable<System.EventArgs> FontChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.FontChanged += h,
                h => source.FontChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ForeColorChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ForeColorChanged += h,
                h => source.ForeColorChanged -= h);
        }
         
        public static IObservable<System.EventArgs> RightToLeftChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.RightToLeftChanged += h,
                h => source.RightToLeftChanged -= h);
        }
         
        public static IObservable<System.EventArgs> TextChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.TextChanged += h,
                h => source.TextChanged -= h);
        }
         
        public static IObservable<System.EventArgs> ClickAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.Click += h,
                h => source.Click -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragDropAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragDrop += h,
                h => source.DragDrop -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragEnterAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragEnter += h,
                h => source.DragEnter -= h);
        }
         
        public static IObservable<System.Windows.Forms.DragEventArgs> DragOverAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.DragEventHandler, System.Windows.Forms.DragEventArgs>(
                h => (sender, args) => h(args),
                h => source.DragOver += h,
                h => source.DragOver -= h);
        }
         
        public static IObservable<System.EventArgs> DragLeaveAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DragLeave += h,
                h => source.DragLeave -= h);
        }
         
        public static IObservable<System.Windows.Forms.GiveFeedbackEventArgs> GiveFeedbackAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.GiveFeedbackEventHandler, System.Windows.Forms.GiveFeedbackEventArgs>(
                h => (sender, args) => h(args),
                h => source.GiveFeedback += h,
                h => source.GiveFeedback -= h);
        }
         
        public static IObservable<System.Windows.Forms.HelpEventArgs> HelpRequestedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.HelpEventHandler, System.Windows.Forms.HelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.HelpRequested += h,
                h => source.HelpRequested -= h);
        }
         
        public static IObservable<System.Windows.Forms.PaintEventArgs> PaintAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.PaintEventHandler, System.Windows.Forms.PaintEventArgs>(
                h => (sender, args) => h(args),
                h => source.Paint += h,
                h => source.Paint -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryContinueDragEventArgs> QueryContinueDragAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryContinueDragEventHandler, System.Windows.Forms.QueryContinueDragEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryContinueDrag += h,
                h => source.QueryContinueDrag -= h);
        }
         
        public static IObservable<System.Windows.Forms.QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.QueryAccessibilityHelpEventHandler, System.Windows.Forms.QueryAccessibilityHelpEventArgs>(
                h => (sender, args) => h(args),
                h => source.QueryAccessibilityHelp += h,
                h => source.QueryAccessibilityHelp -= h);
        }
         
        public static IObservable<System.EventArgs> DoubleClickAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.DoubleClick += h,
                h => source.DoubleClick -= h);
        }
         
        public static IObservable<System.EventArgs> ImeModeChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.ImeModeChanged += h,
                h => source.ImeModeChanged -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyDownAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyDown += h,
                h => source.KeyDown -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyPressEventArgs> KeyPressAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyPressEventHandler, System.Windows.Forms.KeyPressEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyPress += h,
                h => source.KeyPress -= h);
        }
         
        public static IObservable<System.Windows.Forms.KeyEventArgs> KeyUpAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.KeyEventHandler, System.Windows.Forms.KeyEventArgs>(
                h => (sender, args) => h(args),
                h => source.KeyUp += h,
                h => source.KeyUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.LayoutEventArgs> LayoutAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.LayoutEventHandler, System.Windows.Forms.LayoutEventArgs>(
                h => (sender, args) => h(args),
                h => source.Layout += h,
                h => source.Layout -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseDownAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseDown += h,
                h => source.MouseDown -= h);
        }
         
        public static IObservable<System.EventArgs> MouseEnterAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseEnter += h,
                h => source.MouseEnter -= h);
        }
         
        public static IObservable<System.EventArgs> MouseLeaveAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseLeave += h,
                h => source.MouseLeave -= h);
        }
         
        public static IObservable<System.EventArgs> MouseHoverAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseHover += h,
                h => source.MouseHover -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseMoveAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseMove += h,
                h => source.MouseMove -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseUpAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseUp += h,
                h => source.MouseUp -= h);
        }
         
        public static IObservable<System.Windows.Forms.MouseEventArgs> MouseWheelAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.MouseEventHandler, System.Windows.Forms.MouseEventArgs>(
                h => (sender, args) => h(args),
                h => source.MouseWheel += h,
                h => source.MouseWheel -= h);
        }
         
        public static IObservable<System.Windows.Forms.UICuesEventArgs> ChangeUICuesAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.Windows.Forms.UICuesEventHandler, System.Windows.Forms.UICuesEventArgs>(
                h => (sender, args) => h(args),
                h => source.ChangeUICues += h,
                h => source.ChangeUICues -= h);
        }
         
        public static IObservable<System.EventArgs> StyleChangedAsObservable(this WebBrowserBase source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.StyleChanged += h,
                h => source.StyleChanged -= h);
        }
            }
    }
 
namespace System.Windows.Forms.Design
{
     
    public static class ComponentEditorFormEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ComponentEditorForm source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
            }
     
    public static class ComponentEditorPageEventExtensions
    {
         
        public static IObservable<System.EventArgs> AutoSizeChangedAsObservable(this ComponentEditorPage source)
        {
            return Observable.FromEvent<System.EventHandler, System.EventArgs>(
                h => (sender, args) => h(args),
                h => source.AutoSizeChanged += h,
                h => source.AutoSizeChanged -= h);
        }
            }
    }
