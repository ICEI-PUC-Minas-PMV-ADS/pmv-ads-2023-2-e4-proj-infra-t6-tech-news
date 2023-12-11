import { useState } from 'react';
import { Alert } from 'react-native';

import { createNews, deleteNews, updateNews } from '@lib/newsService';

import { Header } from '@components/Header';
import { Highlight } from '@components/Highlight';
import { Container, Content, Icon } from './styles';
import { Button } from '@components/Button';
import { Input } from '@components/Input';

import { useNavigation, useRoute } from '@react-navigation/native';

type NewsItem = {
  id: number;
  title: string;
  link: string;
};

type AddNewProps = {
  isEditing?: boolean;
  existingNews?: NewsItem;
};

export const AddNew: React.FC = () => {
  const route = useRoute();
  const params = route.params as AddNewProps;

  const isEditing = params?.isEditing;
  const existingNews = params?.existingNews;
  const [title, setTitle] = useState(
    isEditing && existingNews ? existingNews.title : ''
  );
  const [link, setLink] = useState(
    isEditing && existingNews ? existingNews.link : ''
  );

  const navigation = useNavigation();

  async function handleSubmit() {
    try {
      if (isEditing && existingNews) {
        await updateNews(existingNews!.id, title, link);
        Alert.alert('Sucesso! 👍', 'Notícia atualizada com sucesso!');
      } else {
        await createNews(title, link);
        Alert.alert('Sucesso! 👍', 'Notícia adicionada com sucesso!');
      }
      setTitle('');
      setLink('');
    } catch (_error) {
      Alert.alert('Erro ⚠', 'Não foi possível processar a solicitação.');
    } finally {
      navigation.navigate('news');
    }
  }

  const handleDelete = () => {
    Alert.alert(
      'Confirmar exclusão ⚠',
      'Tem certeza de que deseja excluir esta notícia?',
      [
        {
          text: 'Cancelar',
          style: 'cancel',
        },
        {
          text: 'Excluir',
          onPress: async () => {
            try {
              if (isEditing && existingNews) {
                await deleteNews(existingNews.id);
                Alert.alert('Sucesso! 👍', 'Notícia deletada com sucesso.');
                navigation.navigate('news');
              }
            } catch (error) {
              Alert.alert('Erro ⚠', 'Não foi possível deletar a notícia.');
            }
          },
        },
      ],
      { cancelable: true }
    );
  };

  return (
    <Container>
      <Header showBackButton />
      <Content>
        <Highlight
          title={isEditing ? 'Editar notícia' : 'Adicionar notícia'}
          subtitle={
            isEditing
              ? 'Atualize as informações da notícia.'
              : 'Ajude outras pessoas a se manterem informadas.'
          }
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
          title={isEditing ? 'Atualizar notícia' : 'Compartilhar notícia'}
          onPress={handleSubmit}
          disabled={!title || !link}
        />

        {isEditing && (
          <Button
            style={{ marginTop: 12 }}
            title={'Deletar notícia'}
            onPress={handleDelete}
            type="DELETE"
          />
        )}
      </Content>
    </Container>
  );
};
