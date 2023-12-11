import { useState } from 'react';
import { Alert } from 'react-native';

import { createUser, EMAIL_REGEX } from '@lib/userService';

import { Highlight } from '@components/Highlight';
import { Container, Content, Icon } from './styles';
import { Button } from '@components/Button';
import { Input } from '@components/Input';
import { useNavigation } from '@react-navigation/native';
import { Header } from '@components/Header';

export function SignUp() {
  const [email, setEmail] = useState('joao@exemplo.com');
  const [password, setPassword] = useState('123456');
  const [confirmation, setConfirmation] = useState('123456');

  const navigation = useNavigation();

  async function handleSignUp() {
    if (confirmation !== password) {
      Alert.alert('Erro ⚠', 'As senhas não coincidem.');

      return;
    }

    if (!EMAIL_REGEX.test(email)) {
      Alert.alert('Erro ⚠', 'Email inválido.');

      return;
    }

    try {
      await createUser(email, password, confirmation);

      setEmail('');
      setPassword('');
      setConfirmation('');
      Alert.alert('Sucesso! 👍', 'Usuário cadastrado com sucesso!');
      navigation.navigate('login');
    } catch (_error) {
      Alert.alert('Erro ⚠', 'Falha ao cadastrar usuário.');
    }
  }

  return (
    <Container>
      <Header showBackButton showLogo={false} />

      <Content>
        <Icon size={128} />

        <Highlight title="Cadastro de Usuário" />

        <Input placeholder="Email" value={email} onChangeText={setEmail} />

        <Input
          placeholder="Senha"
          value={password}
          onChangeText={setPassword}
          secureTextEntry
        />

        <Input
          placeholder="Confirme a Senha"
          value={confirmation}
          onChangeText={setConfirmation}
          secureTextEntry
        />

        <Button
          title="Cadastrar"
          style={{ marginTop: 12 }}
          onPress={handleSignUp}
          disabled={!email || !password || !confirmation}
        />
      </Content>
    </Container>
  );
}
