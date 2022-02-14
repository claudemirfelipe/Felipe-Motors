export class LocalStorageUtils {

    public obterUsuario() {
        return JSON.parse(localStorage.getItem('FelipeMotors.user'));
    }

    public salvarDadosLocaisUsuario(response: any) {
        this.salvarTokenUsuario(response.accessToken);
        this.salvarUsuario(response.userToken);
    }

    public limparDadosLocaisUsuario() {
        localStorage.removeItem('FelipeMotors.token');
        localStorage.removeItem('FelipeMotors.user');
    }

    public obterTokenUsuario(): string {
        return localStorage.getItem('FelipeMotors.token');
    }

    public salvarTokenUsuario(token: string) {
        localStorage.setItem('FelipeMotors.token', token);
    }

    public salvarUsuario(user: string) {
        localStorage.setItem('FelipeMotors.user', JSON.stringify(user));
    }

}
