﻿/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 5         Fall 2018   *                                             
 *                                                          *
 *  Programmers: Tyler Saballus                             *
 *                                                          *
 *  Date Due:   Nov-15 (Turned in one day late)             *                          
 *                                                          *
 *  Purpose:    This is a Sudoku app that allows users to   *
 *              play the popular Sudoku game.               *
 ***********************************************************/

namespace Sudoku
{
    partial class SudokuApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Box1A = new System.Windows.Forms.TextBox();
            this.Box1C = new System.Windows.Forms.TextBox();
            this.Box1B = new System.Windows.Forms.TextBox();
            this.Box3B = new System.Windows.Forms.TextBox();
            this.Box3C = new System.Windows.Forms.TextBox();
            this.Box3A = new System.Windows.Forms.TextBox();
            this.Box2B = new System.Windows.Forms.TextBox();
            this.Box2C = new System.Windows.Forms.TextBox();
            this.Box2A = new System.Windows.Forms.TextBox();
            this.Box2E = new System.Windows.Forms.TextBox();
            this.Box2F = new System.Windows.Forms.TextBox();
            this.Box2D = new System.Windows.Forms.TextBox();
            this.Box3E = new System.Windows.Forms.TextBox();
            this.Box3F = new System.Windows.Forms.TextBox();
            this.Box3D = new System.Windows.Forms.TextBox();
            this.Box1E = new System.Windows.Forms.TextBox();
            this.Box1F = new System.Windows.Forms.TextBox();
            this.Box1D = new System.Windows.Forms.TextBox();
            this.Box2H = new System.Windows.Forms.TextBox();
            this.Box2J = new System.Windows.Forms.TextBox();
            this.Box2G = new System.Windows.Forms.TextBox();
            this.Box3H = new System.Windows.Forms.TextBox();
            this.Box3J = new System.Windows.Forms.TextBox();
            this.Box3G = new System.Windows.Forms.TextBox();
            this.Box1H = new System.Windows.Forms.TextBox();
            this.Box1J = new System.Windows.Forms.TextBox();
            this.Box1G = new System.Windows.Forms.TextBox();
            this.Box8H = new System.Windows.Forms.TextBox();
            this.Box8J = new System.Windows.Forms.TextBox();
            this.Box8G = new System.Windows.Forms.TextBox();
            this.Box9H = new System.Windows.Forms.TextBox();
            this.Box9J = new System.Windows.Forms.TextBox();
            this.Box9G = new System.Windows.Forms.TextBox();
            this.Box7H = new System.Windows.Forms.TextBox();
            this.Box7J = new System.Windows.Forms.TextBox();
            this.Box7G = new System.Windows.Forms.TextBox();
            this.Box8E = new System.Windows.Forms.TextBox();
            this.Box8F = new System.Windows.Forms.TextBox();
            this.Box8D = new System.Windows.Forms.TextBox();
            this.Box9E = new System.Windows.Forms.TextBox();
            this.Box9F = new System.Windows.Forms.TextBox();
            this.Box9D = new System.Windows.Forms.TextBox();
            this.Box7E = new System.Windows.Forms.TextBox();
            this.Box7F = new System.Windows.Forms.TextBox();
            this.Box7D = new System.Windows.Forms.TextBox();
            this.Box8B = new System.Windows.Forms.TextBox();
            this.Box8C = new System.Windows.Forms.TextBox();
            this.Box8A = new System.Windows.Forms.TextBox();
            this.Box9B = new System.Windows.Forms.TextBox();
            this.Box9C = new System.Windows.Forms.TextBox();
            this.Box9A = new System.Windows.Forms.TextBox();
            this.Box7B = new System.Windows.Forms.TextBox();
            this.Box7C = new System.Windows.Forms.TextBox();
            this.Box7A = new System.Windows.Forms.TextBox();
            this.Box5H = new System.Windows.Forms.TextBox();
            this.Box5J = new System.Windows.Forms.TextBox();
            this.Box5G = new System.Windows.Forms.TextBox();
            this.Box6H = new System.Windows.Forms.TextBox();
            this.Box6J = new System.Windows.Forms.TextBox();
            this.Box6G = new System.Windows.Forms.TextBox();
            this.Box4H = new System.Windows.Forms.TextBox();
            this.Box4J = new System.Windows.Forms.TextBox();
            this.Box4G = new System.Windows.Forms.TextBox();
            this.Box5E = new System.Windows.Forms.TextBox();
            this.Box5F = new System.Windows.Forms.TextBox();
            this.Box5D = new System.Windows.Forms.TextBox();
            this.Box6E = new System.Windows.Forms.TextBox();
            this.Box6F = new System.Windows.Forms.TextBox();
            this.Box6D = new System.Windows.Forms.TextBox();
            this.Box4E = new System.Windows.Forms.TextBox();
            this.Box4F = new System.Windows.Forms.TextBox();
            this.Box4D = new System.Windows.Forms.TextBox();
            this.Box5B = new System.Windows.Forms.TextBox();
            this.Box5C = new System.Windows.Forms.TextBox();
            this.Box5A = new System.Windows.Forms.TextBox();
            this.Box6B = new System.Windows.Forms.TextBox();
            this.Box6C = new System.Windows.Forms.TextBox();
            this.Box6A = new System.Windows.Forms.TextBox();
            this.Box4B = new System.Windows.Forms.TextBox();
            this.Box4C = new System.Windows.Forms.TextBox();
            this.Box4A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.CheckSolutionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PuzzleTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.AvgLabel = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Box1A
            // 
            this.Box1A.Location = new System.Drawing.Point(1211, 263);
            this.Box1A.Margin = new System.Windows.Forms.Padding(7);
            this.Box1A.Name = "Box1A";
            this.Box1A.Size = new System.Drawing.Size(51, 35);
            this.Box1A.TabIndex = 0;
            this.Box1A.Click += AnyTextBox_Click;
            this.Box1A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1C
            // 
            this.Box1C.Location = new System.Drawing.Point(1351, 263);
            this.Box1C.Margin = new System.Windows.Forms.Padding(7);
            this.Box1C.Name = "Box1C";
            this.Box1C.Size = new System.Drawing.Size(51, 35);
            this.Box1C.TabIndex = 1;
            this.Box1C.Click += AnyTextBox_Click;
            this.Box1C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1B
            // 
            this.Box1B.Location = new System.Drawing.Point(1281, 263);
            this.Box1B.Margin = new System.Windows.Forms.Padding(7);
            this.Box1B.Name = "Box1B";
            this.Box1B.Size = new System.Drawing.Size(51, 35);
            this.Box1B.TabIndex = 2;
            this.Box1B.Click += AnyTextBox_Click;
            this.Box1B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3B
            // 
            this.Box3B.Location = new System.Drawing.Point(1281, 379);
            this.Box3B.Margin = new System.Windows.Forms.Padding(7);
            this.Box3B.Name = "Box3B";
            this.Box3B.Size = new System.Drawing.Size(51, 35);
            this.Box3B.TabIndex = 5;
            this.Box3B.Click += AnyTextBox_Click;
            this.Box3B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3C
            // 
            this.Box3C.Location = new System.Drawing.Point(1351, 379);
            this.Box3C.Margin = new System.Windows.Forms.Padding(7);
            this.Box3C.Name = "Box3C";
            this.Box3C.Size = new System.Drawing.Size(51, 35);
            this.Box3C.TabIndex = 4;
            this.Box3C.Click += AnyTextBox_Click;
            this.Box3C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3A
            // 
            this.Box3A.Location = new System.Drawing.Point(1211, 379);
            this.Box3A.Margin = new System.Windows.Forms.Padding(7);
            this.Box3A.Name = "Box3A";
            this.Box3A.Size = new System.Drawing.Size(51, 35);
            this.Box3A.TabIndex = 3;
            this.Box3A.Click += AnyTextBox_Click;
            this.Box3A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2B
            // 
            this.Box2B.Location = new System.Drawing.Point(1281, 321);
            this.Box2B.Margin = new System.Windows.Forms.Padding(7);
            this.Box2B.Name = "Box2B";
            this.Box2B.Size = new System.Drawing.Size(51, 35);
            this.Box2B.TabIndex = 8;
            this.Box2B.Click += AnyTextBox_Click;
            this.Box2B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2C
            // 
            this.Box2C.Location = new System.Drawing.Point(1351, 321);
            this.Box2C.Margin = new System.Windows.Forms.Padding(7);
            this.Box2C.Name = "Box2C";
            this.Box2C.Size = new System.Drawing.Size(51, 35);
            this.Box2C.TabIndex = 7;
            this.Box2C.Click += AnyTextBox_Click;
            this.Box2C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2A
            // 
            this.Box2A.Location = new System.Drawing.Point(1211, 321);
            this.Box2A.Margin = new System.Windows.Forms.Padding(7);
            this.Box2A.Name = "Box2A";
            this.Box2A.Size = new System.Drawing.Size(51, 35);
            this.Box2A.TabIndex = 6;
            this.Box2A.Click += AnyTextBox_Click;
            this.Box2A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2E
            // 
            this.Box2E.Location = new System.Drawing.Point(1542, 321);
            this.Box2E.Margin = new System.Windows.Forms.Padding(7);
            this.Box2E.Name = "Box2E";
            this.Box2E.Size = new System.Drawing.Size(51, 35);
            this.Box2E.TabIndex = 17;
            this.Box2E.Click += AnyTextBox_Click;
            this.Box2E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2F
            // 
            this.Box2F.Location = new System.Drawing.Point(1612, 321);
            this.Box2F.Margin = new System.Windows.Forms.Padding(7);
            this.Box2F.Name = "Box2F";
            this.Box2F.Size = new System.Drawing.Size(51, 35);
            this.Box2F.TabIndex = 16;
            this.Box2F.Click += AnyTextBox_Click;
            this.Box2F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2D
            // 
            this.Box2D.Location = new System.Drawing.Point(1472, 321);
            this.Box2D.Margin = new System.Windows.Forms.Padding(7);
            this.Box2D.Name = "Box2D";
            this.Box2D.Size = new System.Drawing.Size(51, 35);
            this.Box2D.TabIndex = 15;
            this.Box2D.Click += AnyTextBox_Click;
            this.Box2D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3E
            // 
            this.Box3E.Location = new System.Drawing.Point(1542, 379);
            this.Box3E.Margin = new System.Windows.Forms.Padding(7);
            this.Box3E.Name = "Box3E";
            this.Box3E.Size = new System.Drawing.Size(51, 35);
            this.Box3E.TabIndex = 14;
            this.Box3E.Click += AnyTextBox_Click;
            this.Box3E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3F
            // 
            this.Box3F.Location = new System.Drawing.Point(1612, 379);
            this.Box3F.Margin = new System.Windows.Forms.Padding(7);
            this.Box3F.Name = "Box3F";
            this.Box3F.Size = new System.Drawing.Size(51, 35);
            this.Box3F.TabIndex = 13;
            this.Box3F.Click += AnyTextBox_Click;
            this.Box3F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3D
            // 
            this.Box3D.Location = new System.Drawing.Point(1472, 379);
            this.Box3D.Margin = new System.Windows.Forms.Padding(7);
            this.Box3D.Name = "Box3D";
            this.Box3D.Size = new System.Drawing.Size(51, 35);
            this.Box3D.TabIndex = 12;
            this.Box3D.Click += AnyTextBox_Click;
            this.Box3D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1E
            // 
            this.Box1E.Location = new System.Drawing.Point(1542, 263);
            this.Box1E.Margin = new System.Windows.Forms.Padding(7);
            this.Box1E.Name = "Box1E";
            this.Box1E.Size = new System.Drawing.Size(51, 35);
            this.Box1E.TabIndex = 11;
            this.Box1E.Click += AnyTextBox_Click;
            this.Box1E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1F
            // 
            this.Box1F.Location = new System.Drawing.Point(1612, 263);
            this.Box1F.Margin = new System.Windows.Forms.Padding(7);
            this.Box1F.Name = "Box1F";
            this.Box1F.Size = new System.Drawing.Size(51, 35);
            this.Box1F.TabIndex = 10;
            this.Box1F.Click += AnyTextBox_Click;
            this.Box1F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1D
            // 
            this.Box1D.Location = new System.Drawing.Point(1472, 263);
            this.Box1D.Margin = new System.Windows.Forms.Padding(7);
            this.Box1D.Name = "Box1D";
            this.Box1D.Size = new System.Drawing.Size(51, 35);
            this.Box1D.TabIndex = 9;
            this.Box1D.Click += AnyTextBox_Click;
            this.Box1D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2H
            // 
            this.Box2H.Location = new System.Drawing.Point(1801, 321);
            this.Box2H.Margin = new System.Windows.Forms.Padding(7);
            this.Box2H.Name = "Box2H";
            this.Box2H.Size = new System.Drawing.Size(51, 35);
            this.Box2H.TabIndex = 26;
            this.Box2H.Click += AnyTextBox_Click;
            this.Box2H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2J
            // 
            this.Box2J.Location = new System.Drawing.Point(1871, 321);
            this.Box2J.Margin = new System.Windows.Forms.Padding(7);
            this.Box2J.Name = "Box2J";
            this.Box2J.Size = new System.Drawing.Size(51, 35);
            this.Box2J.TabIndex = 25;
            this.Box2J.Click += AnyTextBox_Click;
            this.Box2J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box2G
            // 
            this.Box2G.Location = new System.Drawing.Point(1731, 321);
            this.Box2G.Margin = new System.Windows.Forms.Padding(7);
            this.Box2G.Name = "Box2G";
            this.Box2G.Size = new System.Drawing.Size(51, 35);
            this.Box2G.TabIndex = 24;
            this.Box2G.Click += AnyTextBox_Click;
            this.Box2G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3H
            // 
            this.Box3H.Location = new System.Drawing.Point(1801, 379);
            this.Box3H.Margin = new System.Windows.Forms.Padding(7);
            this.Box3H.Name = "Box3H";
            this.Box3H.Size = new System.Drawing.Size(51, 35);
            this.Box3H.TabIndex = 23;
            this.Box3H.Click += AnyTextBox_Click;
            this.Box3H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3J
            // 
            this.Box3J.Location = new System.Drawing.Point(1871, 379);
            this.Box3J.Margin = new System.Windows.Forms.Padding(7);
            this.Box3J.Name = "Box3J";
            this.Box3J.Size = new System.Drawing.Size(51, 35);
            this.Box3J.TabIndex = 22;
            this.Box3J.Click += AnyTextBox_Click;
            this.Box3J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box3G
            // 
            this.Box3G.Location = new System.Drawing.Point(1731, 379);
            this.Box3G.Margin = new System.Windows.Forms.Padding(7);
            this.Box3G.Name = "Box3G";
            this.Box3G.Size = new System.Drawing.Size(51, 35);
            this.Box3G.TabIndex = 21;
            this.Box3G.Click += AnyTextBox_Click;
            this.Box3G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1H
            // 
            this.Box1H.Location = new System.Drawing.Point(1801, 263);
            this.Box1H.Margin = new System.Windows.Forms.Padding(7);
            this.Box1H.Name = "Box1H";
            this.Box1H.Size = new System.Drawing.Size(51, 35);
            this.Box1H.TabIndex = 20;
            this.Box1H.Click += AnyTextBox_Click;
            this.Box1H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1J
            // 
            this.Box1J.Location = new System.Drawing.Point(1871, 263);
            this.Box1J.Margin = new System.Windows.Forms.Padding(7);
            this.Box1J.Name = "Box1J";
            this.Box1J.Size = new System.Drawing.Size(51, 35);
            this.Box1J.TabIndex = 19;
            this.Box1J.Click += AnyTextBox_Click;
            this.Box1J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box1G
            // 
            this.Box1G.Location = new System.Drawing.Point(1731, 263);
            this.Box1G.Margin = new System.Windows.Forms.Padding(7);
            this.Box1G.Name = "Box1G";
            this.Box1G.Size = new System.Drawing.Size(51, 35);
            this.Box1G.TabIndex = 18;
            this.Box1G.Click += AnyTextBox_Click;
            this.Box1G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8H
            // 
            this.Box8H.Location = new System.Drawing.Point(1801, 729);
            this.Box8H.Margin = new System.Windows.Forms.Padding(7);
            this.Box8H.Name = "Box8H";
            this.Box8H.Size = new System.Drawing.Size(51, 35);
            this.Box8H.TabIndex = 53;
            this.Box8H.Click += AnyTextBox_Click;
            this.Box8H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8J
            // 
            this.Box8J.Location = new System.Drawing.Point(1871, 729);
            this.Box8J.Margin = new System.Windows.Forms.Padding(7);
            this.Box8J.Name = "Box8J";
            this.Box8J.Size = new System.Drawing.Size(51, 35);
            this.Box8J.TabIndex = 52;
            this.Box8J.Click += AnyTextBox_Click;
            this.Box8J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8G
            // 
            this.Box8G.Location = new System.Drawing.Point(1731, 729);
            this.Box8G.Margin = new System.Windows.Forms.Padding(7);
            this.Box8G.Name = "Box8G";
            this.Box8G.Size = new System.Drawing.Size(51, 35);
            this.Box8G.TabIndex = 51;
            this.Box8G.Click += AnyTextBox_Click;
            this.Box8G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9H
            // 
            this.Box9H.Location = new System.Drawing.Point(1801, 787);
            this.Box9H.Margin = new System.Windows.Forms.Padding(7);
            this.Box9H.Name = "Box9H";
            this.Box9H.Size = new System.Drawing.Size(51, 35);
            this.Box9H.TabIndex = 50;
            this.Box9H.Click += AnyTextBox_Click;
            this.Box9H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9J
            // 
            this.Box9J.Location = new System.Drawing.Point(1871, 787);
            this.Box9J.Margin = new System.Windows.Forms.Padding(7);
            this.Box9J.Name = "Box9J";
            this.Box9J.Size = new System.Drawing.Size(51, 35);
            this.Box9J.TabIndex = 49;
            this.Box9J.Click += AnyTextBox_Click;
            this.Box9J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9G
            // 
            this.Box9G.Location = new System.Drawing.Point(1731, 787);
            this.Box9G.Margin = new System.Windows.Forms.Padding(7);
            this.Box9G.Name = "Box9G";
            this.Box9G.Size = new System.Drawing.Size(51, 35);
            this.Box9G.TabIndex = 48;
            this.Box9G.Click += AnyTextBox_Click;
            this.Box9G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7H
            // 
            this.Box7H.Location = new System.Drawing.Point(1801, 671);
            this.Box7H.Margin = new System.Windows.Forms.Padding(7);
            this.Box7H.Name = "Box7H";
            this.Box7H.Size = new System.Drawing.Size(51, 35);
            this.Box7H.TabIndex = 47;
            this.Box7H.Click += AnyTextBox_Click;
            this.Box7H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7J
            // 
            this.Box7J.Location = new System.Drawing.Point(1871, 671);
            this.Box7J.Margin = new System.Windows.Forms.Padding(7);
            this.Box7J.Name = "Box7J";
            this.Box7J.Size = new System.Drawing.Size(51, 35);
            this.Box7J.TabIndex = 46;
            this.Box7J.Click += AnyTextBox_Click;
            this.Box7J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7G
            // 
            this.Box7G.Location = new System.Drawing.Point(1731, 671);
            this.Box7G.Margin = new System.Windows.Forms.Padding(7);
            this.Box7G.Name = "Box7G";
            this.Box7G.Size = new System.Drawing.Size(51, 35);
            this.Box7G.TabIndex = 45;
            this.Box7G.Click += AnyTextBox_Click;
            this.Box7G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8E
            // 
            this.Box8E.Location = new System.Drawing.Point(1542, 729);
            this.Box8E.Margin = new System.Windows.Forms.Padding(7);
            this.Box8E.Name = "Box8E";
            this.Box8E.Size = new System.Drawing.Size(51, 35);
            this.Box8E.TabIndex = 44;
            this.Box8E.Click += AnyTextBox_Click;
            this.Box8E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8F
            // 
            this.Box8F.Location = new System.Drawing.Point(1612, 729);
            this.Box8F.Margin = new System.Windows.Forms.Padding(7);
            this.Box8F.Name = "Box8F";
            this.Box8F.Size = new System.Drawing.Size(51, 35);
            this.Box8F.TabIndex = 43;
            this.Box8F.Click += AnyTextBox_Click;
            this.Box8F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8D
            // 
            this.Box8D.Location = new System.Drawing.Point(1472, 729);
            this.Box8D.Margin = new System.Windows.Forms.Padding(7);
            this.Box8D.Name = "Box8D";
            this.Box8D.Size = new System.Drawing.Size(51, 35);
            this.Box8D.TabIndex = 42;
            this.Box8D.Click += AnyTextBox_Click;
            this.Box8D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9E
            // 
            this.Box9E.Location = new System.Drawing.Point(1542, 787);
            this.Box9E.Margin = new System.Windows.Forms.Padding(7);
            this.Box9E.Name = "Box9E";
            this.Box9E.Size = new System.Drawing.Size(51, 35);
            this.Box9E.TabIndex = 41;
            this.Box9E.Click += AnyTextBox_Click;
            this.Box9E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9F
            // 
            this.Box9F.Location = new System.Drawing.Point(1612, 787);
            this.Box9F.Margin = new System.Windows.Forms.Padding(7);
            this.Box9F.Name = "Box9F";
            this.Box9F.Size = new System.Drawing.Size(51, 35);
            this.Box9F.TabIndex = 40;
            this.Box9F.Click += AnyTextBox_Click;
            this.Box9F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9D
            // 
            this.Box9D.Location = new System.Drawing.Point(1472, 787);
            this.Box9D.Margin = new System.Windows.Forms.Padding(7);
            this.Box9D.Name = "Box9D";
            this.Box9D.Size = new System.Drawing.Size(51, 35);
            this.Box9D.TabIndex = 39;
            this.Box9D.Click += AnyTextBox_Click;
            this.Box9D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7E
            // 
            this.Box7E.Location = new System.Drawing.Point(1542, 671);
            this.Box7E.Margin = new System.Windows.Forms.Padding(7);
            this.Box7E.Name = "Box7E";
            this.Box7E.Size = new System.Drawing.Size(51, 35);
            this.Box7E.TabIndex = 38;
            this.Box7E.Click += AnyTextBox_Click;
            this.Box7E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7F
            // 
            this.Box7F.Location = new System.Drawing.Point(1612, 671);
            this.Box7F.Margin = new System.Windows.Forms.Padding(7);
            this.Box7F.Name = "Box7F";
            this.Box7F.Size = new System.Drawing.Size(51, 35);
            this.Box7F.TabIndex = 37;
            this.Box7F.Click += AnyTextBox_Click;
            this.Box7F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7D
            // 
            this.Box7D.Location = new System.Drawing.Point(1472, 671);
            this.Box7D.Margin = new System.Windows.Forms.Padding(7);
            this.Box7D.Name = "Box7D";
            this.Box7D.Size = new System.Drawing.Size(51, 35);
            this.Box7D.TabIndex = 36;
            this.Box7D.Click += AnyTextBox_Click;
            this.Box7D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8B
            // 
            this.Box8B.Location = new System.Drawing.Point(1281, 729);
            this.Box8B.Margin = new System.Windows.Forms.Padding(7);
            this.Box8B.Name = "Box8B";
            this.Box8B.Size = new System.Drawing.Size(51, 35);
            this.Box8B.TabIndex = 35;
            this.Box8B.Click += AnyTextBox_Click;
            this.Box8B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8C
            // 
            this.Box8C.Location = new System.Drawing.Point(1351, 729);
            this.Box8C.Margin = new System.Windows.Forms.Padding(7);
            this.Box8C.Name = "Box8C";
            this.Box8C.Size = new System.Drawing.Size(51, 35);
            this.Box8C.TabIndex = 34;
            this.Box8C.Click += AnyTextBox_Click;
            this.Box8C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box8A
            // 
            this.Box8A.Location = new System.Drawing.Point(1211, 729);
            this.Box8A.Margin = new System.Windows.Forms.Padding(7);
            this.Box8A.Name = "Box8A";
            this.Box8A.Size = new System.Drawing.Size(51, 35);
            this.Box8A.TabIndex = 33;
            this.Box8A.Click += AnyTextBox_Click;
            this.Box8A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9B
            // 
            this.Box9B.Location = new System.Drawing.Point(1281, 787);
            this.Box9B.Margin = new System.Windows.Forms.Padding(7);
            this.Box9B.Name = "Box9B";
            this.Box9B.Size = new System.Drawing.Size(51, 35);
            this.Box9B.TabIndex = 32;
            this.Box9B.Click += AnyTextBox_Click;
            this.Box9B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9C
            // 
            this.Box9C.Location = new System.Drawing.Point(1351, 787);
            this.Box9C.Margin = new System.Windows.Forms.Padding(7);
            this.Box9C.Name = "Box9C";
            this.Box9C.Size = new System.Drawing.Size(51, 35);
            this.Box9C.TabIndex = 31;
            this.Box9C.Click += AnyTextBox_Click;
            this.Box9C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box9A
            // 
            this.Box9A.Location = new System.Drawing.Point(1211, 787);
            this.Box9A.Margin = new System.Windows.Forms.Padding(7);
            this.Box9A.Name = "Box9A";
            this.Box9A.Size = new System.Drawing.Size(51, 35);
            this.Box9A.TabIndex = 30;
            this.Box9A.Click += AnyTextBox_Click;
            this.Box9A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7B
            // 
            this.Box7B.Location = new System.Drawing.Point(1281, 671);
            this.Box7B.Margin = new System.Windows.Forms.Padding(7);
            this.Box7B.Name = "Box7B";
            this.Box7B.Size = new System.Drawing.Size(51, 35);
            this.Box7B.TabIndex = 29;
            this.Box7B.Click += AnyTextBox_Click;
            this.Box7B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7C
            // 
            this.Box7C.Location = new System.Drawing.Point(1351, 671);
            this.Box7C.Margin = new System.Windows.Forms.Padding(7);
            this.Box7C.Name = "Box7C";
            this.Box7C.Size = new System.Drawing.Size(51, 35);
            this.Box7C.TabIndex = 28;
            this.Box7C.Click += AnyTextBox_Click;
            this.Box7C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box7A
            // 
            this.Box7A.Location = new System.Drawing.Point(1211, 671);
            this.Box7A.Margin = new System.Windows.Forms.Padding(7);
            this.Box7A.Name = "Box7A";
            this.Box7A.Size = new System.Drawing.Size(51, 35);
            this.Box7A.TabIndex = 27;
            this.Box7A.Click += AnyTextBox_Click;
            this.Box7A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5H
            // 
            this.Box5H.Location = new System.Drawing.Point(1801, 526);
            this.Box5H.Margin = new System.Windows.Forms.Padding(7);
            this.Box5H.Name = "Box5H";
            this.Box5H.Size = new System.Drawing.Size(51, 35);
            this.Box5H.TabIndex = 80;
            this.Box5H.Click += AnyTextBox_Click;
            this.Box5H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5J
            // 
            this.Box5J.Location = new System.Drawing.Point(1871, 526);
            this.Box5J.Margin = new System.Windows.Forms.Padding(7);
            this.Box5J.Name = "Box5J";
            this.Box5J.Size = new System.Drawing.Size(51, 35);
            this.Box5J.TabIndex = 79;
            this.Box5J.Click += AnyTextBox_Click;
            this.Box5J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5G
            // 
            this.Box5G.Location = new System.Drawing.Point(1731, 526);
            this.Box5G.Margin = new System.Windows.Forms.Padding(7);
            this.Box5G.Name = "Box5G";
            this.Box5G.Size = new System.Drawing.Size(51, 35);
            this.Box5G.TabIndex = 78;
            this.Box5G.Click += AnyTextBox_Click;
            this.Box5G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6H
            // 
            this.Box6H.Location = new System.Drawing.Point(1801, 584);
            this.Box6H.Margin = new System.Windows.Forms.Padding(7);
            this.Box6H.Name = "Box6H";
            this.Box6H.Size = new System.Drawing.Size(51, 35);
            this.Box6H.TabIndex = 77;
            this.Box6H.Click += AnyTextBox_Click;
            this.Box6H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6J
            // 
            this.Box6J.Location = new System.Drawing.Point(1871, 584);
            this.Box6J.Margin = new System.Windows.Forms.Padding(7);
            this.Box6J.Name = "Box6J";
            this.Box6J.Size = new System.Drawing.Size(51, 35);
            this.Box6J.TabIndex = 76;
            this.Box6J.Click += AnyTextBox_Click;
            this.Box6J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6G
            // 
            this.Box6G.Location = new System.Drawing.Point(1731, 584);
            this.Box6G.Margin = new System.Windows.Forms.Padding(7);
            this.Box6G.Name = "Box6G";
            this.Box6G.Size = new System.Drawing.Size(51, 35);
            this.Box6G.TabIndex = 75;
            this.Box6G.Click += AnyTextBox_Click;
            this.Box6G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4H
            // 
            this.Box4H.Location = new System.Drawing.Point(1801, 468);
            this.Box4H.Margin = new System.Windows.Forms.Padding(7);
            this.Box4H.Name = "Box4H";
            this.Box4H.Size = new System.Drawing.Size(51, 35);
            this.Box4H.TabIndex = 74;
            this.Box4H.Click += AnyTextBox_Click;
            this.Box4H.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4J
            // 
            this.Box4J.Location = new System.Drawing.Point(1871, 468);
            this.Box4J.Margin = new System.Windows.Forms.Padding(7);
            this.Box4J.Name = "Box4J";
            this.Box4J.Size = new System.Drawing.Size(51, 35);
            this.Box4J.TabIndex = 73;
            this.Box4J.Click += AnyTextBox_Click;
            this.Box4J.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4G
            // 
            this.Box4G.Location = new System.Drawing.Point(1731, 468);
            this.Box4G.Margin = new System.Windows.Forms.Padding(7);
            this.Box4G.Name = "Box4G";
            this.Box4G.Size = new System.Drawing.Size(51, 35);
            this.Box4G.TabIndex = 72;
            this.Box4G.Click += AnyTextBox_Click;
            this.Box4G.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5E
            // 
            this.Box5E.Location = new System.Drawing.Point(1542, 526);
            this.Box5E.Margin = new System.Windows.Forms.Padding(7);
            this.Box5E.Name = "Box5E";
            this.Box5E.Size = new System.Drawing.Size(51, 35);
            this.Box5E.TabIndex = 71;
            this.Box5E.Click += AnyTextBox_Click;
            this.Box5E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5F
            //
            this.Box5F.Location = new System.Drawing.Point(1612, 526);
            this.Box5F.Margin = new System.Windows.Forms.Padding(7);
            this.Box5F.Name = "Box5F";
            this.Box5F.Size = new System.Drawing.Size(51, 35);
            this.Box5F.TabIndex = 70;
            this.Box5F.Click += AnyTextBox_Click;
            this.Box5F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5D
            // 
            this.Box5D.Location = new System.Drawing.Point(1472, 526);
            this.Box5D.Margin = new System.Windows.Forms.Padding(7);
            this.Box5D.Name = "Box5D";
            this.Box5D.Size = new System.Drawing.Size(51, 35);
            this.Box5D.TabIndex = 69;
            this.Box5D.Click += AnyTextBox_Click;
            this.Box5D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6E
            // 
            this.Box6E.Location = new System.Drawing.Point(1542, 584);
            this.Box6E.Margin = new System.Windows.Forms.Padding(7);
            this.Box6E.Name = "Box6E";
            this.Box6E.Size = new System.Drawing.Size(51, 35);
            this.Box6E.TabIndex = 68;
            this.Box6E.Click += AnyTextBox_Click;
            this.Box6E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6F
            // 
            this.Box6F.Location = new System.Drawing.Point(1612, 584);
            this.Box6F.Margin = new System.Windows.Forms.Padding(7);
            this.Box6F.Name = "Box6F";
            this.Box6F.Size = new System.Drawing.Size(51, 35);
            this.Box6F.TabIndex = 67;
            this.Box6F.Click += AnyTextBox_Click;
            this.Box6F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6D
            // 
            this.Box6D.Location = new System.Drawing.Point(1472, 584);
            this.Box6D.Margin = new System.Windows.Forms.Padding(7);
            this.Box6D.Name = "Box6D";
            this.Box6D.Size = new System.Drawing.Size(51, 35);
            this.Box6D.TabIndex = 66;
            this.Box6D.Click += AnyTextBox_Click;
            this.Box6D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4E
            // 
            this.Box4E.Location = new System.Drawing.Point(1537, 468);
            this.Box4E.Margin = new System.Windows.Forms.Padding(7);
            this.Box4E.Name = "Box4E";
            this.Box4E.Size = new System.Drawing.Size(51, 35);
            this.Box4E.TabIndex = 65;
            this.Box4E.Click += AnyTextBox_Click;
            this.Box4E.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4F
            // 
            this.Box4F.Location = new System.Drawing.Point(1612, 468);
            this.Box4F.Margin = new System.Windows.Forms.Padding(7);
            this.Box4F.Name = "Box4F";
            this.Box4F.Size = new System.Drawing.Size(51, 35);
            this.Box4F.TabIndex = 64;
            this.Box4F.Click += AnyTextBox_Click;
            this.Box4F.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4D
            // 
            this.Box4D.Location = new System.Drawing.Point(1472, 468);
            this.Box4D.Margin = new System.Windows.Forms.Padding(7);
            this.Box4D.Name = "Box4D";
            this.Box4D.Size = new System.Drawing.Size(51, 35);
            this.Box4D.TabIndex = 63;
            this.Box4D.Click += AnyTextBox_Click;
            this.Box4D.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5B
            // 
            this.Box5B.Location = new System.Drawing.Point(1281, 526);
            this.Box5B.Margin = new System.Windows.Forms.Padding(7);
            this.Box5B.Name = "Box5B";
            this.Box5B.Size = new System.Drawing.Size(51, 35);
            this.Box5B.TabIndex = 62;
            this.Box5B.Click += AnyTextBox_Click;
            this.Box5B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5C
            // 
            this.Box5C.Location = new System.Drawing.Point(1351, 526);
            this.Box5C.Margin = new System.Windows.Forms.Padding(7);
            this.Box5C.Name = "Box5C";
            this.Box5C.Size = new System.Drawing.Size(51, 35);
            this.Box5C.TabIndex = 61;
            this.Box5C.Click += AnyTextBox_Click;
            this.Box5C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box5A
            // 
            this.Box5A.Location = new System.Drawing.Point(1211, 526);
            this.Box5A.Margin = new System.Windows.Forms.Padding(7);
            this.Box5A.Name = "Box5A";
            this.Box5A.Size = new System.Drawing.Size(51, 35);
            this.Box5A.TabIndex = 60;
            this.Box5A.Click += AnyTextBox_Click;
            this.Box5A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6B
            // 
            this.Box6B.Location = new System.Drawing.Point(1281, 584);
            this.Box6B.Margin = new System.Windows.Forms.Padding(7);
            this.Box6B.Name = "Box6B";
            this.Box6B.Size = new System.Drawing.Size(51, 35);
            this.Box6B.TabIndex = 59;
            this.Box6B.Click += AnyTextBox_Click;
            this.Box6B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6C
            // 
            this.Box6C.Location = new System.Drawing.Point(1351, 584);
            this.Box6C.Margin = new System.Windows.Forms.Padding(7);
            this.Box6C.Name = "Box6C";
            this.Box6C.Size = new System.Drawing.Size(51, 35);
            this.Box6C.TabIndex = 58;
            this.Box6C.Click += AnyTextBox_Click;
            this.Box6C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box6A
            // 
            this.Box6A.Location = new System.Drawing.Point(1211, 584);
            this.Box6A.Margin = new System.Windows.Forms.Padding(7);
            this.Box6A.Name = "Box6A";
            this.Box6A.Size = new System.Drawing.Size(51, 35);
            this.Box6A.TabIndex = 57;
            this.Box6A.Click += AnyTextBox_Click;
            this.Box6A.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4B
            // 
            this.Box4B.Location = new System.Drawing.Point(1281, 468);
            this.Box4B.Margin = new System.Windows.Forms.Padding(7);
            this.Box4B.Name = "Box4B";
            this.Box4B.Size = new System.Drawing.Size(51, 35);
            this.Box4B.TabIndex = 56;
            this.Box4B.Click += AnyTextBox_Click;
            this.Box4B.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4C
            // 
            this.Box4C.Location = new System.Drawing.Point(1351, 468);
            this.Box4C.Margin = new System.Windows.Forms.Padding(7);
            this.Box4C.Name = "Box4C";
            this.Box4C.Size = new System.Drawing.Size(51, 35);
            this.Box4C.TabIndex = 55;
            this.Box4C.Click += AnyTextBox_Click;
            this.Box4C.KeyUp += AnyTextBox_KeyUp;
            // 
            // Box4A
            // 
            this.Box4A.Location = new System.Drawing.Point(1211, 468);
            this.Box4A.Margin = new System.Windows.Forms.Padding(7);
            this.Box4A.Name = "Box4A";
            this.Box4A.Size = new System.Drawing.Size(51, 35);
            this.Box4A.TabIndex = 54;
            this.Box4A.Click += AnyTextBox_Click;
            this.Box4A.KeyUp += AnyTextBox_KeyUp;            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 76);
            this.label1.TabIndex = 81;
            this.label1.Text = "Sudoku";
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.Location = new System.Drawing.Point(236, 373);
            this.DifficultyBox.Margin = new System.Windows.Forms.Padding(7);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(153, 37);
            this.DifficultyBox.TabIndex = 82;
            this.DifficultyBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 40);
            this.label2.TabIndex = 83;
            this.label2.Text = "New Game:";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.DifficultyLabel.Location = new System.Drawing.Point(1201, 111);
            this.DifficultyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(0, 55);
            this.DifficultyLabel.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "Select Difficulty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 40);
            this.label4.TabIndex = 87;
            this.label4.Text = "Current Game:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(47, 611);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 51);
            this.SaveButton.TabIndex = 88;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(236, 611);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(7);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(175, 51);
            this.ResetButton.TabIndex = 89;
            this.ResetButton.Text = "Reset Game";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(425, 611);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(7);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(175, 51);
            this.HelpButton.TabIndex = 90;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // CheckSolutionButton
            // 
            this.CheckSolutionButton.Location = new System.Drawing.Point(1437, 877);
            this.CheckSolutionButton.Margin = new System.Windows.Forms.Padding(7);
            this.CheckSolutionButton.Name = "CheckSolutionButton";
            this.CheckSolutionButton.Size = new System.Drawing.Size(264, 51);
            this.CheckSolutionButton.TabIndex = 91;
            this.CheckSolutionButton.Text = "Check Solution";
            this.CheckSolutionButton.UseVisualStyleBackColor = true;
            this.CheckSolutionButton.Click += new System.EventHandler(this.CheckSolutionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 787);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 40);
            this.label5.TabIndex = 92;
            this.label5.Text = "Pause/Resume:";
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(275, 877);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(7);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(352, 51);
            this.PauseButton.TabIndex = 93;
            this.PauseButton.Text = "Pause/Resume";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 888);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 29);
            this.label6.TabIndex = 94;
            this.label6.Text = "Change Status:";
            // 
            // PuzzleTimer
            // 
            this.PuzzleTimer.Interval = 1000;
            this.PuzzleTimer.Tick += new System.EventHandler(this.PuzzleTimer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.TimerLabel.Location = new System.Drawing.Point(1424, 983);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 75);
            this.TimerLabel.TabIndex = 95;
            // 
            // AvgLabel
            // 
            this.AvgLabel.AutoSize = true;
            this.AvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvgLabel.Location = new System.Drawing.Point(1205, 192);
            this.AvgLabel.Name = "AvgLabel";
            this.AvgLabel.Size = new System.Drawing.Size(0, 36);
            this.AvgLabel.TabIndex = 96;
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.WinLabel.Location = new System.Drawing.Point(480, 1076);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(0, 55);
            this.WinLabel.TabIndex = 97;
            // 
            // SudokuApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2109, 1193);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.AvgLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckSolutionButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box5H);
            this.Controls.Add(this.Box5J);
            this.Controls.Add(this.Box5G);
            this.Controls.Add(this.Box6H);
            this.Controls.Add(this.Box6J);
            this.Controls.Add(this.Box6G);
            this.Controls.Add(this.Box4H);
            this.Controls.Add(this.Box4J);
            this.Controls.Add(this.Box4G);
            this.Controls.Add(this.Box5E);
            this.Controls.Add(this.Box5F);
            this.Controls.Add(this.Box5D);
            this.Controls.Add(this.Box6E);
            this.Controls.Add(this.Box6F);
            this.Controls.Add(this.Box6D);
            this.Controls.Add(this.Box4E);
            this.Controls.Add(this.Box4F);
            this.Controls.Add(this.Box4D);
            this.Controls.Add(this.Box5B);
            this.Controls.Add(this.Box5C);
            this.Controls.Add(this.Box5A);
            this.Controls.Add(this.Box6B);
            this.Controls.Add(this.Box6C);
            this.Controls.Add(this.Box6A);
            this.Controls.Add(this.Box4B);
            this.Controls.Add(this.Box4C);
            this.Controls.Add(this.Box4A);
            this.Controls.Add(this.Box8H);
            this.Controls.Add(this.Box8J);
            this.Controls.Add(this.Box8G);
            this.Controls.Add(this.Box9H);
            this.Controls.Add(this.Box9J);
            this.Controls.Add(this.Box9G);
            this.Controls.Add(this.Box7H);
            this.Controls.Add(this.Box7J);
            this.Controls.Add(this.Box7G);
            this.Controls.Add(this.Box8E);
            this.Controls.Add(this.Box8F);
            this.Controls.Add(this.Box8D);
            this.Controls.Add(this.Box9E);
            this.Controls.Add(this.Box9F);
            this.Controls.Add(this.Box9D);
            this.Controls.Add(this.Box7E);
            this.Controls.Add(this.Box7F);
            this.Controls.Add(this.Box7D);
            this.Controls.Add(this.Box8B);
            this.Controls.Add(this.Box8C);
            this.Controls.Add(this.Box8A);
            this.Controls.Add(this.Box9B);
            this.Controls.Add(this.Box9C);
            this.Controls.Add(this.Box9A);
            this.Controls.Add(this.Box7B);
            this.Controls.Add(this.Box7C);
            this.Controls.Add(this.Box7A);
            this.Controls.Add(this.Box2H);
            this.Controls.Add(this.Box2J);
            this.Controls.Add(this.Box2G);
            this.Controls.Add(this.Box3H);
            this.Controls.Add(this.Box3J);
            this.Controls.Add(this.Box3G);
            this.Controls.Add(this.Box1H);
            this.Controls.Add(this.Box1J);
            this.Controls.Add(this.Box1G);
            this.Controls.Add(this.Box2E);
            this.Controls.Add(this.Box2F);
            this.Controls.Add(this.Box2D);
            this.Controls.Add(this.Box3E);
            this.Controls.Add(this.Box3F);
            this.Controls.Add(this.Box3D);
            this.Controls.Add(this.Box1E);
            this.Controls.Add(this.Box1F);
            this.Controls.Add(this.Box1D);
            this.Controls.Add(this.Box2B);
            this.Controls.Add(this.Box2C);
            this.Controls.Add(this.Box2A);
            this.Controls.Add(this.Box3B);
            this.Controls.Add(this.Box3C);
            this.Controls.Add(this.Box3A);
            this.Controls.Add(this.Box1B);
            this.Controls.Add(this.Box1C);
            this.Controls.Add(this.Box1A);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "SudokuApp";
            this.Text = "Sudoku - Tyler Saballus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box1A;
        private System.Windows.Forms.TextBox Box1C;
        private System.Windows.Forms.TextBox Box1B;
        private System.Windows.Forms.TextBox Box3B;
        private System.Windows.Forms.TextBox Box3C;
        private System.Windows.Forms.TextBox Box3A;
        private System.Windows.Forms.TextBox Box2B;
        private System.Windows.Forms.TextBox Box2C;
        private System.Windows.Forms.TextBox Box2A;
        private System.Windows.Forms.TextBox Box2E;
        private System.Windows.Forms.TextBox Box2F;
        private System.Windows.Forms.TextBox Box2D;
        private System.Windows.Forms.TextBox Box3E;
        private System.Windows.Forms.TextBox Box3F;
        private System.Windows.Forms.TextBox Box3D;
        private System.Windows.Forms.TextBox Box1E;
        private System.Windows.Forms.TextBox Box1F;
        private System.Windows.Forms.TextBox Box1D;
        private System.Windows.Forms.TextBox Box2H;
        private System.Windows.Forms.TextBox Box2J;
        private System.Windows.Forms.TextBox Box2G;
        private System.Windows.Forms.TextBox Box3H;
        private System.Windows.Forms.TextBox Box3J;
        private System.Windows.Forms.TextBox Box3G;
        private System.Windows.Forms.TextBox Box1H;
        private System.Windows.Forms.TextBox Box1J;
        private System.Windows.Forms.TextBox Box1G;
        private System.Windows.Forms.TextBox Box8H;
        private System.Windows.Forms.TextBox Box8J;
        private System.Windows.Forms.TextBox Box8G;
        private System.Windows.Forms.TextBox Box9H;
        private System.Windows.Forms.TextBox Box9J;
        private System.Windows.Forms.TextBox Box9G;
        private System.Windows.Forms.TextBox Box7H;
        private System.Windows.Forms.TextBox Box7J;
        private System.Windows.Forms.TextBox Box7G;
        private System.Windows.Forms.TextBox Box8E;
        private System.Windows.Forms.TextBox Box8F;
        private System.Windows.Forms.TextBox Box8D;
        private System.Windows.Forms.TextBox Box9E;
        private System.Windows.Forms.TextBox Box9F;
        private System.Windows.Forms.TextBox Box9D;
        private System.Windows.Forms.TextBox Box7E;
        private System.Windows.Forms.TextBox Box7F;
        private System.Windows.Forms.TextBox Box7D;
        private System.Windows.Forms.TextBox Box8B;
        private System.Windows.Forms.TextBox Box8C;
        private System.Windows.Forms.TextBox Box8A;
        private System.Windows.Forms.TextBox Box9B;
        private System.Windows.Forms.TextBox Box9C;
        private System.Windows.Forms.TextBox Box9A;
        private System.Windows.Forms.TextBox Box7B;
        private System.Windows.Forms.TextBox Box7C;
        private System.Windows.Forms.TextBox Box7A;
        private System.Windows.Forms.TextBox Box5H;
        private System.Windows.Forms.TextBox Box5J;
        private System.Windows.Forms.TextBox Box5G;
        private System.Windows.Forms.TextBox Box6H;
        private System.Windows.Forms.TextBox Box6J;
        private System.Windows.Forms.TextBox Box6G;
        private System.Windows.Forms.TextBox Box4H;
        private System.Windows.Forms.TextBox Box4J;
        private System.Windows.Forms.TextBox Box4G;
        private System.Windows.Forms.TextBox Box5E;
        private System.Windows.Forms.TextBox Box5F;
        private System.Windows.Forms.TextBox Box5D;
        private System.Windows.Forms.TextBox Box6E;
        private System.Windows.Forms.TextBox Box6F;
        private System.Windows.Forms.TextBox Box6D;
        private System.Windows.Forms.TextBox Box4E;
        private System.Windows.Forms.TextBox Box4F;
        private System.Windows.Forms.TextBox Box4D;
        private System.Windows.Forms.TextBox Box5B;
        private System.Windows.Forms.TextBox Box5C;
        private System.Windows.Forms.TextBox Box5A;
        private System.Windows.Forms.TextBox Box6B;
        private System.Windows.Forms.TextBox Box6C;
        private System.Windows.Forms.TextBox Box6A;
        private System.Windows.Forms.TextBox Box4B;
        private System.Windows.Forms.TextBox Box4C;
        private System.Windows.Forms.TextBox Box4A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button CheckSolutionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer PuzzleTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.Label WinLabel;
    }
}

