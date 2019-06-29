// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Cursor;
using osu.Framework.Graphics.Shapes;

namespace osu.Framework.Graphics.Visualisation
{
    internal class ToolWindow : OverlayContainer
    {
        public const float WIDTH = 500;
        public const float HEIGHT = 600;

        protected readonly Container ToolbarContent;

        protected readonly ScrollContainer<Drawable> ScrollContent;

        protected readonly FillFlowContainer MainHorizontalContent;

        public ToolWindow(string title, string keyHelpText)
        {
            AutoSizeAxes = Axes.X;
            Height = HEIGHT;

            Masking = true; // for cursor masking

            AddRangeInternal(new Drawable[]
            {
                new Box
                {
                    Colour = FrameworkColour.GreenDark,
                    RelativeSizeAxes = Axes.Both,
                    Depth = 0
                },
                // new GridContainer
                // {
                //     RelativeSizeAxes = Axes.Y,
                //     AutoSizeAxes = Axes.X,
                //     RowDimensions = new[]
                //     {
                //         new Dimension(GridSizeMode.AutoSize),
                //         new Dimension(),
                //     },
                //     ColumnDimensions = new[]
                //     {
                //         new Dimension(GridSizeMode.AutoSize),
                //     },
                //     Content = new[]
                //     {
                //         new Drawable[]
                //         {
                new FillFlowContainer
                {
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Direction = FillDirection.Vertical,
                    Children = new Drawable[]
                    {
                        new TitleBar(title, keyHelpText, this),
                        new Container //toolbar
                        {
                            RelativeSizeAxes = Axes.X,
                            AutoSizeAxes = Axes.Y,
                            Children = new Drawable[]
                            {
                                new Box
                                {
                                    Colour = FrameworkColour.BlueGreenDark,
                                    RelativeSizeAxes = Axes.Both,
                                },
                                ToolbarContent = new Container
                                {
                                    RelativeSizeAxes = Axes.X,
                                    AutoSizeAxes = Axes.Y,
                                },
                            },
                        }
                    }
                },
                MainHorizontalContent = new FillFlowContainer
                {
                    RelativeSizeAxes = Axes.Y,
                    AutoSizeAxes = Axes.X,
                    Direction = FillDirection.Horizontal,
                    Children = new Drawable[]
                    {
                        ScrollContent = new BasicScrollContainer<Drawable>
                        {
                            RelativeSizeAxes = Axes.Y,
                            Width = WIDTH
                        }
                    }
                },
                new CursorContainer()
            });
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            MainHorizontalContent.Padding = new MarginPadding { Top = TitleBar.HEIGHT + ToolbarContent.DrawHeight };
        }

        protected override void PopIn() => this.FadeIn(100);

        protected override void PopOut() => this.FadeOut(100);
    }
}
