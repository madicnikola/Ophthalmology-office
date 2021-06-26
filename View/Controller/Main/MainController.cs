﻿using System;
using Domen;
using View.Controller.Doctor;
using View.Controller.Pacient;
using View.Dialogs;
using View.UserControls;
using View.UserControls.mode;

namespace View.Controller
{
	public class MainController
	{
		private FrmMain frmMain;
		private UCHome homePanel;

		private DialogController dialogController;

		private PacientController pacientController;
		private AllPacientsController allPacientsController;

		private DoctorController doctorController;
		private AllDoctorsController allDoctorsController;

		private ExaminController examinController;
		private AllExaminController allExaminController;

		public KorisnikSistema Korisnik { get; set; }

		internal void CloseMainForm()
		{
			Communication.Communication.Instance.Disconnect();
			MainCoordinator.Instance.OpenLoginForm();
		}

		internal void otvoriFrmMain(KorisnikSistema korisnik)
		{
			frmMain = new FrmMain(this);
			Korisnik = korisnik;
			frmMain.LblKorisnik.Text = Korisnik.Ime;
			frmMain.Show();
		}
		internal void openUCPacijent(FrmMain frmMain, UCMode mode)
		{
			if (pacientController == null)
			{
				pacientController = new PacientController(this);
			}
			frmMain.SetPanel(pacientController.open(mode));
		}
		public void OpenUCPacijentDetalji(Pacijent p, UCMode mode)
		{
			if (pacientController == null)
			{
				pacientController = new PacientController(this);
			}
			pacientController.Pacijent = p;
			if (dialogController == null)
			{
				dialogController = new DialogController(this);
			}
			MainCoordinator.Instance.OpenDialog(pacientController.open(mode));
		}

		internal void OpenUCAllPacients(FrmMain frmMain, UCMode mode)
		{
			if (allPacientsController == null)
			{
				allPacientsController = new AllPacientsController(this);
			}
			frmMain.SetPanel(allPacientsController.open(mode));
		}

		internal void OpenUCLekar(FrmMain frmMain, UCMode mode)
		{
			if (doctorController == null)
			{
				doctorController = new DoctorController(this);
			}
			frmMain.SetPanel(doctorController.open(mode));
		}
		public void OpenUCLekarDetalji(Lekar lekar, UCMode mode)
		{
			if (doctorController == null)
			{
				doctorController = new DoctorController(this);
			}
			doctorController.Lekar = lekar;
			if(dialogController == null)
			{
				dialogController = new DialogController(this);
			}
			MainCoordinator.Instance.OpenDialog(doctorController.open(mode));
		}

		internal void OpenUCLekari(FrmMain frmMain, UCMode mode)
		{
			if (allDoctorsController == null)
			{
				allDoctorsController = new AllDoctorsController(this);
			}
			frmMain.SetPanel(allDoctorsController.open(mode));
		}

		internal void OpenUCPregled(FrmMain frmMain, UCMode mode)
		{
			if (examinController == null)
			{
				examinController = new ExaminController(this);
			}
			frmMain.SetPanel(examinController.open(mode));
		}
		public void OpenUCPregledDetalji(Pregled p, UCMode mode)
		{
			if (examinController == null)
			{
				examinController = new ExaminController(this);
			}
			examinController.Pregled = p;
			if (dialogController == null)
			{
				dialogController = new DialogController(this);
			}
			MainCoordinator.Instance.OpenDialog(examinController.open(mode));
		}

		internal void OpenUCPregledi(FrmMain frmMain, UCMode mode)
		{
			if (allExaminController == null)
			{
				allExaminController = new AllExaminController(this);
			}
			frmMain.SetPanel(allExaminController.open(mode));
		}

		internal void openHomePanel()
		{
			if(homePanel == null)
			{
				homePanel = new UCHome();
				homePanel.LblKorisnik.Text = Korisnik.Ime;
				homePanel.Show();
			}
			frmMain.SetPanel(homePanel);
		}
	}
}