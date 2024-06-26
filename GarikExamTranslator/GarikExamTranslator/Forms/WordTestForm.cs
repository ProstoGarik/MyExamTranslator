﻿using ExamTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarikExamTranslator.Forms
{
    public partial class WordTestForm : Form
    {
        private viewModel viewModel;
        private WordListForm returnForm;
        int wordCounter = 1;
        int correctAnswerCounter = 0;
        private WordListClass wordTestClass;

        public WordTestForm(WordListForm returnForm, viewModel viewModel)
        {
            InitializeComponent();
            this.returnForm = returnForm;
            this.viewModel = viewModel;
        }

        private void WordTestForm_Load(object sender, EventArgs e)
        {
            PerfectResultLabel.Visible = false;
            wordTestClass = viewModel.GetTestList();
            UpdateCounters();
            TestResultLabel.Text = "";
            viewModel.ApplyFont(MainWordLabel);
            viewModel.ApplyFont(TestCounterLabel);
            viewModel.ApplyFont(TestResultLabel);
            viewModel.ApplyFont(WordTaskLabel);
            viewModel.ApplyFont(WordTestUpperLabel);
            viewModel.ApplyFont(WordTranslationLabel);
            viewModel.ApplyFont(PerfectResultLabel);

        }

        private void UpdateCounters()
        {
            try
            {
                TestCounterLabel.Text = wordCounter.ToString() + " из " + wordTestClass.GetWordListCount().ToString();
                MainWordLabel.Text = wordTestClass.GetWordByIndex(wordCounter).Word;
                wordCounter++;
            }
            catch
            {
                TestResultLabel.Text = "Ваш результат:\n" + correctAnswerCounter.ToString() + " правильных ответов";
                TestCounterLabel.Text = (wordCounter-1).ToString() + " из " + wordTestClass.GetWordListCount().ToString();
                MainWordLabel.Text = "";
                AnswerButton.Enabled = false;
                TranslationInputTextBox.Enabled = false;
                if(correctAnswerCounter == wordTestClass.GetWordListCount())
                {
                    PerfectResultLabel.Visible = true;
                }
                viewModel.UpdateUserTests(correctAnswerCounter == wordTestClass.GetWordListCount());
            }
            


        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (viewModel.CompareWords(TranslationInputTextBox.Text, wordTestClass.GetWordByIndex(wordCounter-1).Translation))
            {
                correctAnswerCounter++;
            }
            UpdateCounters();
            TranslationInputTextBox.Text = "";
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            viewModel.ClearTestList();
            viewModel.FormResizeCloseOpen(this, returnForm, true);
        }

        private void GoBackButton_MouseEnter(object sender, EventArgs e)
        {
            GoBackButton.Image = Properties.Resources.GoBack_Icon_OnHover;
        }

        private void GoBackButton_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton.Image = Properties.Resources.GoBack_Icon;
        }

        private void AnswerButton_MouseEnter(object sender, EventArgs e)
        {
            AnswerButton.Image = Properties.Resources.Done_Icon_OnHover;
        }

        private void AnswerButton_MouseLeave(object sender, EventArgs e)
        {
            AnswerButton.Image = Properties.Resources.Done_Icon;
        }

        private void WordTestForm_Shown(object sender, EventArgs e)
        {
            Refresh();
        }

        private void WordTestForm_Activated(object sender, EventArgs e)
        {
            Refresh();
        }

        private void TranslationInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AnswerButton_Click(sender, e);
            }
        }
    }
}
