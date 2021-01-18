import { Component, OnInit } from '@angular/core';
import { Usuario } from '../../modelo/usuario';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioServico } from '../../servicos/usuario/usuario.servico';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  ////Sintaxe de binding para atributo, metodos.
  public endImg = "../../../assets/OIP.jpg";
  public tituloImg = "Título adicionado no componete .ts";
  public usuario;
  public usuarios = ["Mina", "Pit", "Zeus", "Era", "Simba", "Ozzy", "?"];
  public returnUrl: string;
  public mensagem: string;
  public ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) { }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams["returnUrl"];
  }

  ////Sintaxe de binding para eventos.
  entrar() {
    if (this.usuario.email == null || this.usuario.senha == null)
    {
      this.mensagem = "Informe E-mail e Senha!";
      document.getElementById('inputEmail').focus();
    }
    else
    {
      this.ativar_spinner = true;
      this.usuarioServico.verificarUsuario(this.usuario)
        .subscribe(
          usuario_json => {
            this.usuarioServico.usuario = usuario_json;

            if (this.returnUrl == null) { this.router.navigate(['/']) }
            else { this.router.navigate([this.returnUrl]) }
          },
          err => {
            //console.log();
            this.mensagem = err.error;
            this.ativar_spinner = false;
          }
        );
    }
  }
}
