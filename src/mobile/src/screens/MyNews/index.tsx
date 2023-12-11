import { useState } from 'react';
import { Alert } from 'react-native';

import { createNews } from '@lib/newsService';

import { Header } from '@components/Header';
import { Highlight } from '@components/Highlight';
import { Container, Content, Icon } from './styles';
import { Button } from '@components/Button';
import { Input } from '@components/Input';

import { useNavigation } from '@react-navigation/native';

export function MyNews() {
  const [title, setTitle] = useState('');
  const [link, setLink] = useState('');

  const navigation = useNavigation();

  async function handleAddNew() {
    try {
      await createNews(title, link);

      setTitle('');
      setLink('');
      Alert.alert('Sucesso! 👍', 'Notícia adicionada com sucesso!');
    } catch (_error) {
      Alert.alert('Erro ⚠', 'Não foi possível adicionar a notícia.');
    } finally {
      navigation.navigate('news');
    }
  }

  return (
    <Container>
      <Header showBackButton />

      <Content>
        <Icon />

        <Highlight
          title="Adicionar notícia"
          subtitle="Ajude outras pessoas a se manterem informadas."
        />

        <Input
          placeholder="Título da notícia"
          value={title}
          onChangeText={setTitle}
        />

        <Input
          placeholder="Link da notícia"
          value={link}
          onChangeText={setLink}
        />

        <Button
          title="Compartilhar notícia"
          style={{ marginTop: 12 }}
          onPress={handleAddNew}
          disabled={!title || !link}
        />
      </Content>
    </Container>
  );
}
